//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.NodeTemplate.NET.RestClient.Mockup
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.NodeTemplate.NET.RestClient.Mockup.Generated.Interfaces;
   using Substrate.NodeTemplate.NET.RestClient.Mockup.Generated.Clients;
   
   public sealed class MockupClient
   {
      private HttpClient _httpClient;
      public IAuraControllerMockupClient AuraControllerClient;
      public IBalancesControllerMockupClient BalancesControllerClient;
      public IGrandpaControllerMockupClient GrandpaControllerClient;
      public ISudoControllerMockupClient SudoControllerClient;
      public ISystemControllerMockupClient SystemControllerClient;
      public ITemplateModuleControllerMockupClient TemplateModuleControllerClient;
      public ITimestampControllerMockupClient TimestampControllerClient;
      public ITransactionPaymentControllerMockupClient TransactionPaymentControllerClient;
      public MockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
         AuraControllerClient = new AuraControllerMockupClient(_httpClient);
         BalancesControllerClient = new BalancesControllerMockupClient(_httpClient);
         GrandpaControllerClient = new GrandpaControllerMockupClient(_httpClient);
         SudoControllerClient = new SudoControllerMockupClient(_httpClient);
         SystemControllerClient = new SystemControllerMockupClient(_httpClient);
         TemplateModuleControllerClient = new TemplateModuleControllerMockupClient(_httpClient);
         TimestampControllerClient = new TimestampControllerMockupClient(_httpClient);
         TransactionPaymentControllerClient = new TransactionPaymentControllerMockupClient(_httpClient);
      }
   }
}
