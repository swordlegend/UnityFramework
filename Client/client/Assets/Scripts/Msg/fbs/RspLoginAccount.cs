// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace fbs
{

using global::System;
using global::FlatBuffers;

public struct RspLoginAccount : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public const ulong HashID = 0x3355878600CA4D08;
  public static RspLoginAccount GetRootAsRspLoginAccount(ByteBuffer _bb) { return GetRootAsRspLoginAccount(_bb, new RspLoginAccount()); }
  public static RspLoginAccount GetRootAsRspLoginAccount(ByteBuffer _bb, RspLoginAccount obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public RspLoginAccount __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte Ok { get { int o = __p.__offset(4); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<RspLoginAccount> CreateRspLoginAccount(FlatBufferBuilder builder,
      byte ok = 0) {
    builder.StartObject(1);
    RspLoginAccount.AddOk(builder, ok);
    return RspLoginAccount.EndRspLoginAccount(builder);
  }

  public static void StartRspLoginAccount(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddOk(FlatBufferBuilder builder, byte ok) { builder.AddByte(0, ok, 0); }
  public static Offset<RspLoginAccount> EndRspLoginAccount(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<RspLoginAccount>(o);
  }
};


}
