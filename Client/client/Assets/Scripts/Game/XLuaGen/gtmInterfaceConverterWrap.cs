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
    public class gtmInterfaceConverterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(gtmInterface.Converter);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 13, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBigEndian", _m_GetBigEndian_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBigEndianInt32", _m_GetBigEndianInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBigEndianUInt16", _m_GetBigEndianUInt16_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBigEndianUInt32", _m_GetBigEndianUInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBigEndianInt64", _m_GetBigEndianInt64_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBigEndianDouble", _m_GetBigEndianDouble_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBigEndianFloat", _m_GetBigEndianFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLittleEndian", _m_GetLittleEndian_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLittleEndianInt32", _m_GetLittleEndianInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLittleEndianUInt32", _m_GetLittleEndianUInt32_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLittleEndianUInt16", _m_GetLittleEndianUInt16_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLittleEndianDouble", _m_GetLittleEndianDouble_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					gtmInterface.Converter gen_ret = new gtmInterface.Converter();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to gtmInterface.Converter constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBigEndian_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = gtmInterface.Converter.GetBigEndian( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    
                        ushort gen_ret = gtmInterface.Converter.GetBigEndian( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        uint gen_ret = gtmInterface.Converter.GetBigEndian( _value );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) || LuaAPI.lua_isint64(L, 1))) 
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                        long gen_ret = gtmInterface.Converter.GetBigEndian( _value );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                        double gen_ret = gtmInterface.Converter.GetBigEndian( _value );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float gen_ret = gtmInterface.Converter.GetBigEndian( _value );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to gtmInterface.Converter.GetBigEndian!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBigEndianInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = gtmInterface.Converter.GetBigEndianInt32( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBigEndianUInt16_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    
                        ushort gen_ret = gtmInterface.Converter.GetBigEndianUInt16( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBigEndianUInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        uint gen_ret = gtmInterface.Converter.GetBigEndianUInt32( _value );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBigEndianInt64_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _value = LuaAPI.lua_toint64(L, 1);
                    
                        long gen_ret = gtmInterface.Converter.GetBigEndianInt64( _value );
                        LuaAPI.lua_pushint64(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBigEndianDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                        double gen_ret = gtmInterface.Converter.GetBigEndianDouble( _value );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBigEndianFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        float gen_ret = gtmInterface.Converter.GetBigEndianFloat( _value );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLittleEndian_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = gtmInterface.Converter.GetLittleEndian( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        uint gen_ret = gtmInterface.Converter.GetLittleEndian( _value );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    
                        ushort gen_ret = gtmInterface.Converter.GetLittleEndian( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                        double gen_ret = gtmInterface.Converter.GetLittleEndian( _value );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to gtmInterface.Converter.GetLittleEndian!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLittleEndianInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _value = LuaAPI.xlua_tointeger(L, 1);
                    
                        int gen_ret = gtmInterface.Converter.GetLittleEndianInt32( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLittleEndianUInt32_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    uint _value = LuaAPI.xlua_touint(L, 1);
                    
                        uint gen_ret = gtmInterface.Converter.GetLittleEndianUInt32( _value );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLittleEndianUInt16_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 1);
                    
                        ushort gen_ret = gtmInterface.Converter.GetLittleEndianUInt16( _value );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLittleEndianDouble_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    double _value = LuaAPI.lua_tonumber(L, 1);
                    
                        double gen_ret = gtmInterface.Converter.GetLittleEndianDouble( _value );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
