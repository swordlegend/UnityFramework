#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class FlatBuffersFlatBufferBuilderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FlatBuffers.FlatBufferBuilder);
			Utils.BeginObjectRegister(type, L, translator, 0, 39, 3, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pad", _m_Pad);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Prep", _m_Prep);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutBool", _m_PutBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutSbyte", _m_PutSbyte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutByte", _m_PutByte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutShort", _m_PutShort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutUshort", _m_PutUshort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutInt", _m_PutInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutUint", _m_PutUint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutLong", _m_PutLong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutUlong", _m_PutUlong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutFloat", _m_PutFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutDouble", _m_PutDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddBool", _m_AddBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddSbyte", _m_AddSbyte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddByte", _m_AddByte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddShort", _m_AddShort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUshort", _m_AddUshort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddInt", _m_AddInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUint", _m_AddUint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddLong", _m_AddLong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUlong", _m_AddUlong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddFloat", _m_AddFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddDouble", _m_AddDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddOffset", _m_AddOffset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartVector", _m_StartVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndVector", _m_EndVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Nested", _m_Nested);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "NotNested", _m_NotNested);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartObject", _m_StartObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Slot", _m_Slot);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateString", _m_CreateString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddStruct", _m_AddStruct);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EndObject", _m_EndObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Required", _m_Required);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Finish", _m_Finish);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FinishSizePrefixed", _m_FinishSizePrefixed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SizedByteArray", _m_SizedByteArray);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ForceDefaults", _g_get_ForceDefaults);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Offset", _g_get_Offset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "DataBuffer", _g_get_DataBuffer);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ForceDefaults", _s_set_ForceDefaults);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _initialSize = LuaAPI.xlua_tointeger(L, 2);
					
					FlatBuffers.FlatBufferBuilder gen_ret = new FlatBuffers.FlatBufferBuilder(_initialSize);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<FlatBuffers.ByteBuffer>(L, 2))
				{
					FlatBuffers.ByteBuffer _buffer = (FlatBuffers.ByteBuffer)translator.GetObject(L, 2, typeof(FlatBuffers.ByteBuffer));
					
					FlatBuffers.FlatBufferBuilder gen_ret = new FlatBuffers.FlatBufferBuilder(_buffer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Pad(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Pad( _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Prep(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _size = LuaAPI.xlua_tointeger(L, 2);
                    int _additionalBytes = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Prep( _size, _additionalBytes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _x = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.PutBool( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutSbyte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    sbyte _x = (sbyte)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.PutSbyte( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutByte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte _x = (byte)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.PutByte( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutShort(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    short _x = (short)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.PutShort( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutUshort(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ushort _x = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.PutUshort( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.PutInt( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutUint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    uint _x = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.PutUint( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutLong(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    long _x = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.PutLong( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutUlong(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ulong _x = LuaAPI.lua_touint64(L, 2);
                    
                    gen_to_be_invoked.PutUlong( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.PutFloat( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutDouble(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    double _x = LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.PutDouble( _x );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _x = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.AddBool( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    bool _x = LuaAPI.lua_toboolean(L, 3);
                    bool _d = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.AddBool( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddBool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddSbyte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    sbyte _x = (sbyte)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.AddSbyte( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    sbyte _x = (sbyte)LuaAPI.xlua_tointeger(L, 3);
                    sbyte _d = (sbyte)LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddSbyte( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddSbyte!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddByte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte _x = (byte)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.AddByte( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    byte _x = (byte)LuaAPI.xlua_tointeger(L, 3);
                    byte _d = (byte)LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddByte( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddByte!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddShort(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    short _x = (short)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.AddShort( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    short _x = (short)LuaAPI.xlua_tointeger(L, 3);
                    int _d = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddShort( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddShort!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUshort(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    ushort _x = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.AddUshort( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    ushort _x = (ushort)LuaAPI.xlua_tointeger(L, 3);
                    ushort _d = (ushort)LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddUshort( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddUshort!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.AddInt( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    int _x = LuaAPI.xlua_tointeger(L, 3);
                    int _d = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddInt( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    uint _x = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.AddUint( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    uint _x = LuaAPI.xlua_touint(L, 3);
                    uint _d = LuaAPI.xlua_touint(L, 4);
                    
                    gen_to_be_invoked.AddUint( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddUint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLong(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))) 
                {
                    long _x = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.AddLong( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isint64(L, 3))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) || LuaAPI.lua_isint64(L, 4))) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    long _x = LuaAPI.lua_toint64(L, 3);
                    long _d = LuaAPI.lua_toint64(L, 4);
                    
                    gen_to_be_invoked.AddLong( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddLong!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUlong(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isuint64(L, 2))) 
                {
                    ulong _x = LuaAPI.lua_touint64(L, 2);
                    
                    gen_to_be_invoked.AddUlong( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3))&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) || LuaAPI.lua_isuint64(L, 4))) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    ulong _x = LuaAPI.lua_touint64(L, 3);
                    ulong _d = LuaAPI.lua_touint64(L, 4);
                    
                    gen_to_be_invoked.AddUlong( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddUlong!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.AddFloat( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    float _x = (float)LuaAPI.lua_tonumber(L, 3);
                    double _d = LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddFloat( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddDouble(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    double _x = LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.AddDouble( _x );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    double _x = LuaAPI.lua_tonumber(L, 3);
                    double _d = LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddDouble( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddDouble!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddOffset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _off = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.AddOffset( _off );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _o = LuaAPI.xlua_tointeger(L, 2);
                    int _x = LuaAPI.xlua_tointeger(L, 3);
                    int _d = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddOffset( _o, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.AddOffset!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _elemSize = LuaAPI.xlua_tointeger(L, 2);
                    int _count = LuaAPI.xlua_tointeger(L, 3);
                    int _alignment = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.StartVector( _elemSize, _count, _alignment );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        FlatBuffers.VectorOffset gen_ret = gen_to_be_invoked.EndVector(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Nested(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _obj = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Nested( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_NotNested(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.NotNested(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartObject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _numfields = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.StartObject( _numfields );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Slot(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _voffset = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Slot( _voffset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _s = LuaAPI.lua_tostring(L, 2);
                    
                        FlatBuffers.StringOffset gen_ret = gen_to_be_invoked.CreateString( _s );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddStruct(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _voffset = LuaAPI.xlua_tointeger(L, 2);
                    int _x = LuaAPI.xlua_tointeger(L, 3);
                    int _d = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddStruct( _voffset, _x, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndObject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        int gen_ret = gen_to_be_invoked.EndObject(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Required(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _table = LuaAPI.xlua_tointeger(L, 2);
                    int _field = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Required( _table, _field );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Finish(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _rootTable = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Finish( _rootTable );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    int _rootTable = LuaAPI.xlua_tointeger(L, 2);
                    string _fileIdentifier = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.Finish( _rootTable, _fileIdentifier );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.Finish!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FinishSizePrefixed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _rootTable = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.FinishSizePrefixed( _rootTable );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    int _rootTable = LuaAPI.xlua_tointeger(L, 2);
                    string _fileIdentifier = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.FinishSizePrefixed( _rootTable, _fileIdentifier );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.FlatBufferBuilder.FinishSizePrefixed!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SizedByteArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.SizedByteArray(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ForceDefaults(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ForceDefaults);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Offset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Offset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_DataBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.DataBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ForceDefaults(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FlatBuffers.FlatBufferBuilder gen_to_be_invoked = (FlatBuffers.FlatBufferBuilder)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ForceDefaults = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
