//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.node_template_runtime
{
    
    
    /// <summary>
    /// >> RuntimeEvent
    /// </summary>
    public enum RuntimeEvent
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> Grandpa
        /// </summary>
        Grandpa = 3,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 4,
        
        /// <summary>
        /// >> TransactionPayment
        /// </summary>
        TransactionPayment = 5,
        
        /// <summary>
        /// >> Sudo
        /// </summary>
        Sudo = 6,
        
        /// <summary>
        /// >> TemplateModule
        /// </summary>
        TemplateModule = 7,
    }
    
    /// <summary>
    /// >> 21 - Variant[node_template_runtime.RuntimeEvent]
    /// </summary>
    public sealed class EnumRuntimeEvent : BaseEnumExt<RuntimeEvent, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumEvent, BaseVoid, BaseVoid, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_grandpa.pallet.EnumEvent, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumEvent, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_transaction_payment.pallet.EnumEvent, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_sudo.pallet.EnumEvent, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_template.pallet.EnumEvent>
    {
    }
}