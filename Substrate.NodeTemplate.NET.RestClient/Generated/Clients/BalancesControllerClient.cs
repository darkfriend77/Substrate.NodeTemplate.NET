//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.NodeTemplate.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.types;
   using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.weak_bounded_vec;
   using Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.NodeTemplate.NET.RestClient.Generated.Interfaces;
   
   public sealed class BalancesControllerClient : BaseClient, IBalancesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public BalancesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U128> GetTotalIssuance()
      {
         return await SendRequestAsync<U128>(_httpClient, "balances/totalissuance");
      }
      public async Task<bool> SubscribeTotalIssuance()
      {
         return await _subscriptionClient.SubscribeAsync("Balances.TotalIssuance");
      }
      public async Task<U128> GetInactiveIssuance()
      {
         return await SendRequestAsync<U128>(_httpClient, "balances/inactiveissuance");
      }
      public async Task<bool> SubscribeInactiveIssuance()
      {
         return await _subscriptionClient.SubscribeAsync("Balances.InactiveIssuance");
      }
      public async Task<AccountData> GetAccount(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<AccountData>(_httpClient, "balances/account", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<bool> SubscribeAccount(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Account", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.AccountParams(key));
      }
      public async Task<WeakBoundedVecT2> GetLocks(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<WeakBoundedVecT2>(_httpClient, "balances/locks", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<bool> SubscribeLocks(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Locks", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.LocksParams(key));
      }
      public async Task<BoundedVecT2> GetReserves(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT2>(_httpClient, "balances/reserves", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<bool> SubscribeReserves(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Reserves", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.ReservesParams(key));
      }
      public async Task<BoundedVecT3> GetHolds(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT3>(_httpClient, "balances/holds", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.HoldsParams(key));
      }
      public async Task<bool> SubscribeHolds(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Holds", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.HoldsParams(key));
      }
      public async Task<BoundedVecT4> GetFreezes(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<BoundedVecT4>(_httpClient, "balances/freezes", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.FreezesParams(key));
      }
      public async Task<bool> SubscribeFreezes(Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Balances.Freezes", Substrate.NodeTemplate.NET.NetApiExt.Generated.Storage.BalancesStorage.FreezesParams(key));
      }
   }
}
