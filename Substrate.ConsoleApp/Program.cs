using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Yaml;
using Serilog;
using Substrate.Integration;
using Substrate.Integration.Client;
using Substrate.Integration.Helper;
using Substrate.NET.Schnorrkel.Keys;
using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using Substrate.NodeTemplate.NET.NetApiExt.Generated;
using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.primitive_types;
using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto;
using Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage;

namespace Substrate.ConsoleApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // configure serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo
                .Console()
                .CreateLogger();

            var config = new ConfigurationBuilder()
                // this will be used more later on
                .SetBasePath(AppContext.BaseDirectory)
                // I chose using YML files for my config data as I am familiar with them
                .AddYamlFile("config.yml")
                .Build();

            // Add this to your C# console app's Main method to give yourself
            // a CancellationToken that is canceled when the user hits Ctrl+C.
            var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("Canceling...");
                cts.Cancel();
                e.Cancel = true;
            };

            try
            {
                Console.WriteLine("Press Ctrl+C to end.");

                // execute bot ...
                await ExecuteConsoleAsync(config, cts.Token);
            }
            catch (OperationCanceledException)
            {
                // This is the normal way we close.
            }

            // Finally, once just before the application exits...
            await Log.CloseAndFlushAsync();
        }

        private static async Task ExecuteConsoleAsync(IConfigurationRoot config, CancellationToken token)
        {
            var networkType = NetworkType.Live;

            var url = config["node:url"];

            Log.Information("Starting the tests on {url}!", url);

            var seed = "0x69bd057a32bcb8b1159f2e71dff8d6d8dda2a783986582d54f4f44568ac8e443";
            var menmonic = "pause impulse parent much outside cancel banana chat easy void assist label";

            var accountSeed = Account.FromSeed(KeyType.Sr25519, Utils.HexToByteArray(seed));
            var accountMnem = Mnemonic.GetAccountFromMnemonic(menmonic, "", KeyType.Sr25519);

            Log.Information("Account from Mnem: {account}", accountMnem);
            Log.Information("Account from Seed: {account}", accountSeed);

           // Log.Information("########### SUBSTRATE CLIENT EXTENSION");

           // // create a new SubstrateClientExt
           // var substrateClientExt = new SubstrateClientExt(new Uri(url), ChargeTransactionPayment.Default());

           // await substrateClientExt.ConnectAsync(true, true, token);
           // Log.Information("Client is connected? {state}", substrateClientExt.IsConnected);

           // // get the runtime version spec name
           // Log.Information("SpecName = {specName}", substrateClientExt.RuntimeVersion.SpecName);

           // // get account balance
           // var accountId32 = new AccountId32();
           // accountId32.Create(accountMnem.Bytes);
           // var balance1 = await substrateClientExt.SystemStorage.Account(accountId32, null, token);
           // Log.Information("{address}: Balance = {balance}", Utils.GetAddressFrom(accountId32.Bytes, 42), balance1);

           // // get account balance alice
           // var accountId32Alice = new AccountId32();
           // accountId32Alice.Create(BaseClient.Alice.Bytes);
           // var balanceAlice = await substrateClientExt.SystemStorage.Account(accountId32Alice, null, token);
           // Log.Information("Alice: Balance = {balance}", balanceAlice.Data.Free.Value);

           // await substrateClientExt.CloseAsync();
           // Log.Information("Client is connected? {state}", substrateClientExt.IsConnected);

           // Log.Information("########### BASE CLIENT");

           // var baseClient = new SubstrateNetwork(null, networkType, url);
           // var connected = await baseClient.ConnectAsync(true, true, token);
           // Log.Information("Client is connected? {state}", connected);

           // // get account balance
           // var balanceAliceSharp = await baseClient.GetAccountAsync(BaseClient.Alice.ToAccountId32(), null, token);
           // Log.Information("Alice: {balance}", balanceAliceSharp.Data.Free);

           //await baseClient.DisconnectAsync();
           // Log.Information("Client is connected? {state}", connected);


            Log.Information("########### BALANCE TRANSFER");

            var client = new SubstrateNetwork(BaseClient.Alice, networkType, url);
            await client.ConnectAsync(true, true, token);

            client.ExtrinsicManager.ExtrinsicUpdated += OnExtrinsicUpdate;

            var subId = await client.TransferKeepAliveAsync(accountSeed.ToAccountId32(), 10 * SubstrateNetwork.DECIMALS, 1, token);
            Log.Information("SubscriptionId[{state}]: {subId}", subId != null ? "OK": "FAIL", subId);
   
            Console.ReadKey();
            await client.DisconnectAsync();
        }

        private static void OnExtrinsicUpdate(string subscriptionId, ExtrinsicInfo extrinsicInfo)
        {
            Log.Information("SubscriptionId {subscriptionId} - {ExtrinsicStatus} - [{index}|{hash}] - Events:{events}", subscriptionId, extrinsicInfo.TransactionEvent, extrinsicInfo.Index, extrinsicInfo.Hash?.Value, extrinsicInfo.EventRecords?.Count);

            if (extrinsicInfo.TransactionEvent != NetApi.Model.Rpc.TransactionEvent.Finalized)
            {
                return;
            }

            extrinsicInfo.EventRecords.ForEach(e =>
            {
                Log.Information("Event {Event}", e.Event.Value);

                switch (e.Event.Value2)
                {
                    case NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumEvent typedEvent:
                        Log.Information("+- Event Value2 {fullname}", typedEvent.Value);
                        switch (typedEvent.Value)
                        {
                            case NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.pallet.Event.Transfer:
                                {
                                    var typedValues = (BaseTuple<AccountId32, AccountId32, U128>)typedEvent.Value2;
                                    Log.Information("   +- Transfer {from} -> {to} - {value}", ((AccountId32)typedValues.Value[0]).ToAddress(), ((AccountId32)typedValues.Value[1]).ToAddress(), ((U128)typedValues.Value[2]).Value.ToString());
                                    break;
                                }
                            case NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.pallet.Event.Withdraw:
                                {
                                    var typedValues = (BaseTuple<AccountId32, U128>)typedEvent.Value2;
                                    Log.Information("   +- Withdraw {from} - {value}", ((AccountId32)typedValues.Value[0]).ToAddress(), ((U128)typedValues.Value[1]).Value.ToString());
                                }
                                break;
                            case NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.pallet.Event.Deposit:
                                {
                                    var typedValues = (BaseTuple<AccountId32, U128>)typedEvent.Value2;
                                    Log.Information("   +- Deposit {from} - {value}", ((AccountId32)typedValues.Value[0]).ToAddress(), ((U128)typedValues.Value[1]).Value.ToString());
                                }
                                break;
                        }
                        break;

                    case NodeTemplate.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumEvent typedEvent:
                        Log.Information("+- Event Value2 {fullname}", typedEvent.Value);
                        switch (typedEvent.Value)
                        {
                            case NodeTemplate.NET.NetApiExt.Generated.Model.frame_system.pallet.Event.Remarked:
                                {
                                    var typedValues = (BaseTuple<AccountId32, H256>)typedEvent.Value2;
                                    Log.Information("   +- Remarked {from} - {hash}", ((AccountId32)typedValues.Value[0]).ToAddress(), ((H256)typedValues.Value[1]).ToHexString());
                                }
                                break;
                        }
                        break;

                    // add unhandled cases ...
                    default:
                        Log.Information("Unhandled event type: {Type}", e.Event.Value2.GetType().Name);
                        var value2 = e.Event.Value2;
                        Type type = value2.GetType();
                        foreach (var property in type.GetProperties())
                        {
                            var propertyName = property.Name;
                            var propertyValue = property.GetValue(value2, null);
                            Log.Information("   +- {PropertyName}: {PropertyValue}", propertyName, propertyValue);
                        }
                        break;
                }
            });
        }
    }
}
