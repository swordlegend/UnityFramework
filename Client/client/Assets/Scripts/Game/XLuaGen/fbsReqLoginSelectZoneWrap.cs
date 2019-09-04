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
    public class fbsReqLoginSelectZoneWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(fbs.ReqLoginSelectZone);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__init", _m___init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__assign", _m___assign);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ByteBuffer", _g_get_ByteBuffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Zoneid", _g_get_Zoneid);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRootAsReqLoginSelectZone", _m_GetRootAsReqLoginSelectZone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateReqLoginSelectZone", _m_CreateReqLoginSelectZone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StartReqLoginSelectZone", _m_StartReqLoginSelectZone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddZoneid", _m_AddZoneid_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndReqLoginSelectZone", _m_EndReqLoginSelectZone_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HashID", fbs.ReqLoginSelectZone.HashID);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(fbs.ReqLoginSelectZone));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.ReqLoginSelectZone constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRootAsReqLoginSelectZone_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.ReqLoginSelectZone gen_ret = fbs.ReqLoginSelectZone.GetRootAsReqLoginSelectZone( __bb );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)&& translator.Assignable<fbs.ReqLoginSelectZone>(L, 2)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    fbs.ReqLoginSelectZone _obj;translator.Get(L, 2, out _obj);
                    
                        fbs.ReqLoginSelectZone gen_ret = fbs.ReqLoginSelectZone.GetRootAsReqLoginSelectZone( __bb, _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.ReqLoginSelectZone.GetRootAsReqLoginSelectZone!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.ReqLoginSelectZone gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int __i = LuaAPI.xlua_tointeger(L, 2);
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 3, typeof(FlatBuffers.ByteBuffer));
                    
                    gen_to_be_invoked.__init( __i, __bb );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___assign(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.ReqLoginSelectZone gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int __i = LuaAPI.xlua_tointeger(L, 2);
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 3, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.ReqLoginSelectZone gen_ret = gen_to_be_invoked.__assign( __i, __bb );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateReqLoginSelectZone_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<FlatBuffers.FlatBufferBuilder>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    ushort _zoneid = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                        FlatBuffers.Offset<fbs.ReqLoginSelectZone> gen_ret = fbs.ReqLoginSelectZone.CreateReqLoginSelectZone( _builder, _zoneid );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<FlatBuffers.FlatBufferBuilder>(L, 1)) 
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                        FlatBuffers.Offset<fbs.ReqLoginSelectZone> gen_ret = fbs.ReqLoginSelectZone.CreateReqLoginSelectZone( _builder );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.ReqLoginSelectZone.CreateReqLoginSelectZone!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartReqLoginSelectZone_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                    fbs.ReqLoginSelectZone.StartReqLoginSelectZone( _builder );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddZoneid_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    ushort _zoneid = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                    fbs.ReqLoginSelectZone.AddZoneid( _builder, _zoneid );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndReqLoginSelectZone_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                        FlatBuffers.Offset<fbs.ReqLoginSelectZone> gen_ret = fbs.ReqLoginSelectZone.EndReqLoginSelectZone( _builder );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ByteBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                fbs.ReqLoginSelectZone gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.ByteBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Zoneid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                fbs.ReqLoginSelectZone gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Zoneid);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
