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


namespace Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.pallet_grandpa.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> report_equivocation
        /// Report voter equivocation/misbehavior. This method will verify the
        /// equivocation proof and validate the given key ownership proof
        /// against the extracted offender. If both are valid, the offence
        /// will be reported.
        /// </summary>
        report_equivocation = 0,
        
        /// <summary>
        /// >> report_equivocation_unsigned
        /// Report voter equivocation/misbehavior. This method will verify the
        /// equivocation proof and validate the given key ownership proof
        /// against the extracted offender. If both are valid, the offence
        /// will be reported.
        /// 
        /// This extrinsic must be called unsigned and it is expected that only
        /// block authors will call it (validated in `ValidateUnsigned`), as such
        /// if the block author is defined it will be defined as the equivocation
        /// reporter.
        /// </summary>
        report_equivocation_unsigned = 1,
        
        /// <summary>
        /// >> note_stalled
        /// Note that the current authority set of the GRANDPA finality gadget has stalled.
        /// 
        /// This will trigger a forced authority set change at the beginning of the next session, to
        /// be enacted `delay` blocks after that. The `delay` should be high enough to safely assume
        /// that the block signalling the forced change will not be re-orged e.g. 1000 blocks.
        /// The block production rate (which may be slowed down because of finality lagging) should
        /// be taken into account when choosing the `delay`. The GRANDPA voters based on the new
        /// authority will start voting on top of `best_finalized_block_number` for new finalized
        /// blocks. `best_finalized_block_number` should be the highest of the latest finalized
        /// block of all validators of the new authority set.
        /// 
        /// Only callable by root.
        /// </summary>
        note_stalled = 2,
    }
    
    /// <summary>
    /// >> 80 - Variant[pallet_grandpa.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.EquivocationProof, Substrate.NetApi.Model.Types.Base.BaseVoid>, BaseTuple<Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_consensus_grandpa.EquivocationProof, Substrate.NetApi.Model.Types.Base.BaseVoid>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
