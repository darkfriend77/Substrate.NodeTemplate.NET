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


namespace Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_sudo.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Sudid
        /// A sudo call just took place.
        /// </summary>
        Sudid = 0,
        
        /// <summary>
        /// >> KeyChanged
        /// The sudo key has been updated.
        /// </summary>
        KeyChanged = 1,
        
        /// <summary>
        /// >> KeyRemoved
        /// The key was permanently removed.
        /// </summary>
        KeyRemoved = 2,
        
        /// <summary>
        /// >> SudoAsDone
        /// A [sudo_as](Pallet::sudo_as) call just took place.
        /// </summary>
        SudoAsDone = 3,
    }
    
    /// <summary>
    /// >> 39 - Variant[pallet_sudo.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.EnumResult, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseVoid, Substrate.NodeTemplate.NET.NetApiExt.Generated.Types.Base.EnumResult>
    {
    }
}