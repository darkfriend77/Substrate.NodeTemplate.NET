//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.NodeTemplate.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NodeTemplate.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.NodeTemplate.NET.RestClient.Generated.Clients;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   
   public class BalancesControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestTotalIssuance()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();


         Assert.IsTrue(await rpcClient.SubscribeTotalIssuance());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetTotalIssuance(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetTotalIssuance();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestInactiveIssuance()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U128 mockupValue = this.GetTestValueU128();


         Assert.IsTrue(await rpcClient.SubscribeInactiveIssuance());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetInactiveIssuance(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U128 rpcResult = await rpcClient.GetInactiveIssuance();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData GetTestValue4()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData();
         result.Free = this.GetTestValueU128();
         result.Reserved = this.GetTestValueU128();
         result.Frozen = this.GetTestValueU128();
         result.Flags = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ExtraFlags();
         result.Flags = this.GetTestValue5();
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ExtraFlags GetTestValue5()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ExtraFlags result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ExtraFlags();
         result.Value = this.GetTestValueU128();
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue6()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAccount()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData mockupValue = this.GetTestValue4();
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue6();

         Assert.IsTrue(await rpcClient.SubscribeAccount(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAccount(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.AccountData rpcResult = await rpcClient.GetAccount(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2 GetTestValue8()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.BalanceLock>();
         result.Value.Create(new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.BalanceLock[] {
                  this.GetTestValue9()});
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.BalanceLock GetTestValue9()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.BalanceLock result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.BalanceLock();
         result.Id = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.Arr8U8();
         result.Id.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         result.Amount = this.GetTestValueU128();
         result.Reasons = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.EnumReasons();
         result.Reasons.Create(this.GetTestValueEnum<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.Reasons>());
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue10()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestLocks()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2 mockupValue = this.GetTestValue8();
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue10();

         Assert.IsTrue(await rpcClient.SubscribeLocks(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetLocks(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec.WeakBoundedVecT2 rpcResult = await rpcClient.GetLocks(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 GetTestValue12()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ReserveData>();
         result.Value.Create(new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ReserveData[] {
                  this.GetTestValue13()});
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ReserveData GetTestValue13()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ReserveData result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.ReserveData();
         result.Id = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.Arr8U8();
         result.Id.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         result.Amount = this.GetTestValueU128();
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue14()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestReserves()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 mockupValue = this.GetTestValue12();
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue14();

         Assert.IsTrue(await rpcClient.SubscribeReserves(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetReserves(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT2 rpcResult = await rpcClient.GetReserves(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 GetTestValue16()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount>();
         result.Value.Create(new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount[] {
                  this.GetTestValue17()});
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount GetTestValue17()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount();
         result.Id = new Substrate.NetApi.Model.Types.Base.BaseTuple();
         result.Amount = this.GetTestValueU128();
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue18()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestHolds()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 mockupValue = this.GetTestValue16();
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue18();

         Assert.IsTrue(await rpcClient.SubscribeHolds(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetHolds(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT3 rpcResult = await rpcClient.GetHolds(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4 GetTestValue20()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4();
         result.Value = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount>();
         result.Value.Create(new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount[] {
                  this.GetTestValue21()});
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount GetTestValue21()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types.IdAmount();
         result.Id = new Substrate.NetApi.Model.Types.Base.BaseTuple();
         result.Amount = this.GetTestValueU128();
         return result;
      }
      public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 GetTestValue22()
      {
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestFreezes()
      {
         // Construct new Mockup client to test with.
         BalancesControllerMockupClient mockupClient = new BalancesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         BalancesControllerClient rpcClient = new BalancesControllerClient(_httpClient, subscriptionClient);
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4 mockupValue = this.GetTestValue20();
         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue22();

         Assert.IsTrue(await rpcClient.SubscribeFreezes(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetFreezes(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4 rpcResult = await rpcClient.GetFreezes(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
