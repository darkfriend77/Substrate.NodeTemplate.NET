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
    /// >> RuntimeCall
    /// </summary>
    public enum RuntimeCall
    {
        
        /// <summary>
        /// >> System
        /// </summary>
        System = 0,
        
        /// <summary>
        /// >> Timestamp
        /// </summary>
        Timestamp = 1,
        
        /// <summary>
        /// >> Grandpa
        /// </summary>
        Grandpa = 3,
        
        /// <summary>
        /// >> Balances
        /// </summary>
        Balances = 4,
        
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
    /// >> 116 - Variant[node_template_runtime.RuntimeCall]
    /// </summary>
    public sealed class EnumRuntimeCall : BaseEnumExt<RuntimeCall, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumCall, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_timestamp.pallet.EnumCall, BaseVoid, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_grandpa.pallet.EnumCall, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_balances.pallet.EnumCall, BaseVoid, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_sudo.pallet.EnumCall, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_template.pallet.EnumCall>
    {
    }
}
