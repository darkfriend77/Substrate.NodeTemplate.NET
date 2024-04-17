//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.frame_support.dispatch
{
    
    
    /// <summary>
    /// >> 23 - Composite[frame_support.dispatch.DispatchInfo]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DispatchInfo : BaseType
    {
        
        /// <summary>
        /// >> weight
        /// </summary>
        public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight Weight { get; set; }
        /// <summary>
        /// >> class
        /// </summary>
        public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.frame_support.dispatch.EnumDispatchClass Class { get; set; }
        /// <summary>
        /// >> pays_fee
        /// </summary>
        public Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.frame_support.dispatch.EnumPays PaysFee { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "DispatchInfo";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Weight.Encode());
            result.AddRange(Class.Encode());
            result.AddRange(PaysFee.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Weight = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
            Weight.Decode(byteArray, ref p);
            Class = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.frame_support.dispatch.EnumDispatchClass();
            Class.Decode(byteArray, ref p);
            PaysFee = new Substrate.NodeTemplate.NET.NetApiExt.Generated.Model.frame_support.dispatch.EnumPays();
            PaysFee.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
