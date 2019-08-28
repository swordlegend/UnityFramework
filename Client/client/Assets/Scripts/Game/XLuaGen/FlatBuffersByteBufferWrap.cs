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
    public class FlatBuffersByteBufferWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FlatBuffers.ByteBuffer);
			Utils.BeginObjectRegister(type, L, translator, 0, 31, 2, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reset", _m_Reset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Duplicate", _m_Duplicate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GrowFront", _m_GrowFront);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToArray", _m_ToArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToSizedArray", _m_ToSizedArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToFullArray", _m_ToFullArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToArraySegment", _m_ToArraySegment);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToMemoryStream", _m_ToMemoryStream);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutSbyte", _m_PutSbyte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutByte", _m_PutByte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Put", _m_Put);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutStringUTF8", _m_PutStringUTF8);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutShort", _m_PutShort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutUshort", _m_PutUshort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutInt", _m_PutInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutUint", _m_PutUint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutLong", _m_PutLong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutUlong", _m_PutUlong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutFloat", _m_PutFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PutDouble", _m_PutDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSbyte", _m_GetSbyte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Get", _m_Get);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetStringUTF8", _m_GetStringUTF8);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetShort", _m_GetShort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUshort", _m_GetUshort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInt", _m_GetInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUint", _m_GetUint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLong", _m_GetLong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUlong", _m_GetUlong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloat", _m_GetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDouble", _m_GetDouble);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Position", _g_get_Position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Length", _g_get_Length);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Position", _s_set_Position);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ReverseBytes", _m_ReverseBytes_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<FlatBuffers.ByteBufferAllocator>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					FlatBuffers.ByteBufferAllocator _allocator = (FlatBuffers.ByteBufferAllocator)translator.GetObject(L, 2, typeof(FlatBuffers.ByteBufferAllocator));
					int _position = LuaAPI.xlua_tointeger(L, 3);
					
					FlatBuffers.ByteBuffer gen_ret = new FlatBuffers.ByteBuffer(_allocator, _position);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int _size = LuaAPI.xlua_tointeger(L, 2);
					
					FlatBuffers.ByteBuffer gen_ret = new FlatBuffers.ByteBuffer(_size);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
					
					FlatBuffers.ByteBuffer gen_ret = new FlatBuffers.ByteBuffer(_buffer);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
					int _pos = LuaAPI.xlua_tointeger(L, 3);
					
					FlatBuffers.ByteBuffer gen_ret = new FlatBuffers.ByteBuffer(_buffer, _pos);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.ByteBuffer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Reset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Duplicate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        FlatBuffers.ByteBuffer gen_ret = gen_to_be_invoked.Duplicate(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GrowFront(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _newSize = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.GrowFront( _newSize );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _pos = LuaAPI.xlua_tointeger(L, 2);
                    int _len = LuaAPI.xlua_tointeger(L, 3);
                    
                        byte[] gen_ret = gen_to_be_invoked.ToArray( _pos, _len );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToSizedArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.ToSizedArray(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToFullArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.ToFullArray(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToArraySegment(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _pos = LuaAPI.xlua_tointeger(L, 2);
                    int _len = LuaAPI.xlua_tointeger(L, 3);
                    
                        System.ArraySegment<byte> gen_ret = gen_to_be_invoked.ToArraySegment( _pos, _len );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToMemoryStream(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _pos = LuaAPI.xlua_tointeger(L, 2);
                    int _len = LuaAPI.xlua_tointeger(L, 3);
                    
                        System.IO.MemoryStream gen_ret = gen_to_be_invoked.ToMemoryStream( _pos, _len );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReverseBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    ushort _input = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    
                        ushort gen_ret = FlatBuffers.ByteBuffer.ReverseBytes( _input );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    uint _input = LuaAPI.xlua_touint(L, 1);
                    
                        uint gen_ret = FlatBuffers.ByteBuffer.ReverseBytes( _input );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isuint64(L, 1))) 
                {
                    ulong _input = LuaAPI.lua_touint64(L, 1);
                    
                        ulong gen_ret = FlatBuffers.ByteBuffer.ReverseBytes( _input );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.ByteBuffer.ReverseBytes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutSbyte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    sbyte _value = (sbyte)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.PutSbyte( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _value = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.PutByte( _offset, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _value = (byte)LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.PutByte( _offset, _value, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to FlatBuffers.ByteBuffer.PutByte!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Put(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    byte _value = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Put( _offset, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PutStringUTF8(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    string _value = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.PutStringUTF8( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    short _value = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.PutShort( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.PutUshort( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.PutInt( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    uint _value = LuaAPI.xlua_touint(L, 3);
                    
                    gen_to_be_invoked.PutUint( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    long _value = LuaAPI.lua_toint64(L, 3);
                    
                    gen_to_be_invoked.PutLong( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    ulong _value = LuaAPI.lua_touint64(L, 3);
                    
                    gen_to_be_invoked.PutUlong( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.PutFloat( _offset, _value );
                    
                    
                    
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
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _offset = LuaAPI.xlua_tointeger(L, 2);
                    double _value = LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.PutDouble( _offset, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSbyte(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        sbyte gen_ret = gen_to_be_invoked.GetSbyte( _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Get(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        byte gen_ret = gen_to_be_invoked.Get( _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStringUTF8(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _startPos = LuaAPI.xlua_tointeger(L, 2);
                    int _len = LuaAPI.xlua_tointeger(L, 3);
                    
                        string gen_ret = gen_to_be_invoked.GetStringUTF8( _startPos, _len );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetShort(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        short gen_ret = gen_to_be_invoked.GetShort( _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUshort(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        ushort gen_ret = gen_to_be_invoked.GetUshort( _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        int gen_ret = gen_to_be_invoked.GetInt( _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        uint gen_ret = gen_to_be_invoked.GetUint( _index );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLong(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        long gen_ret = gen_to_be_invoked.GetLong( _index );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUlong(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        ulong gen_ret = gen_to_be_invoked.GetUlong( _index );
                        LuaAPI.lua_pushuint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        float gen_ret = gen_to_be_invoked.GetFloat( _index );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDouble(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        double gen_ret = gen_to_be_invoked.GetDouble( _index );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Position);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Length);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FlatBuffers.ByteBuffer gen_to_be_invoked = (FlatBuffers.ByteBuffer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Position = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
