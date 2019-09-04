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
    public class fbsReqLoginAccountWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(fbs.ReqLoginAccount);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__init", _m___init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__assign", _m___assign);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAccountBytes", _m_GetAccountBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAccountArray", _m_GetAccountArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPasswordBytes", _m_GetPasswordBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPasswordArray", _m_GetPasswordArray);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ByteBuffer", _g_get_ByteBuffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Account", _g_get_Account);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Password", _g_get_Password);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRootAsReqLoginAccount", _m_GetRootAsReqLoginAccount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateReqLoginAccount", _m_CreateReqLoginAccount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StartReqLoginAccount", _m_StartReqLoginAccount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddAccount", _m_AddAccount_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddPassword", _m_AddPassword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndReqLoginAccount", _m_EndReqLoginAccount_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HashID", fbs.ReqLoginAccount.HashID);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(fbs.ReqLoginAccount));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.ReqLoginAccount constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRootAsReqLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.ReqLoginAccount gen_ret = fbs.ReqLoginAccount.GetRootAsReqLoginAccount( __bb );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)&& translator.Assignable<fbs.ReqLoginAccount>(L, 2)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    fbs.ReqLoginAccount _obj;translator.Get(L, 2, out _obj);
                    
                        fbs.ReqLoginAccount gen_ret = fbs.ReqLoginAccount.GetRootAsReqLoginAccount( __bb, _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.ReqLoginAccount.GetRootAsReqLoginAccount!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
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
            
            
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int __i = LuaAPI.xlua_tointeger(L, 2);
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 3, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.ReqLoginAccount gen_ret = gen_to_be_invoked.__assign( __i, __bb );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAccountBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        System.Nullable<System.ArraySegment<byte>> gen_ret = gen_to_be_invoked.GetAccountBytes(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAccountArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.GetAccountArray(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPasswordBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        System.Nullable<System.ArraySegment<byte>> gen_ret = gen_to_be_invoked.GetPasswordBytes(  );
                        translator.PushAny(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPasswordArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        byte[] gen_ret = gen_to_be_invoked.GetPasswordArray(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateReqLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<FlatBuffers.FlatBufferBuilder>(L, 1)&& translator.Assignable<FlatBuffers.StringOffset>(L, 2)&& translator.Assignable<FlatBuffers.StringOffset>(L, 3)) 
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    FlatBuffers.StringOffset _accountOffset;translator.Get(L, 2, out _accountOffset);
                    FlatBuffers.StringOffset _passwordOffset;translator.Get(L, 3, out _passwordOffset);
                    
                        FlatBuffers.Offset<fbs.ReqLoginAccount> gen_ret = fbs.ReqLoginAccount.CreateReqLoginAccount( _builder, _accountOffset, _passwordOffset );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<FlatBuffers.FlatBufferBuilder>(L, 1)&& translator.Assignable<FlatBuffers.StringOffset>(L, 2)) 
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    FlatBuffers.StringOffset _accountOffset;translator.Get(L, 2, out _accountOffset);
                    
                        FlatBuffers.Offset<fbs.ReqLoginAccount> gen_ret = fbs.ReqLoginAccount.CreateReqLoginAccount( _builder, _accountOffset );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<FlatBuffers.FlatBufferBuilder>(L, 1)) 
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                        FlatBuffers.Offset<fbs.ReqLoginAccount> gen_ret = fbs.ReqLoginAccount.CreateReqLoginAccount( _builder );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.ReqLoginAccount.CreateReqLoginAccount!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartReqLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                    fbs.ReqLoginAccount.StartReqLoginAccount( _builder );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    FlatBuffers.StringOffset _accountOffset;translator.Get(L, 2, out _accountOffset);
                    
                    fbs.ReqLoginAccount.AddAccount( _builder, _accountOffset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddPassword_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    FlatBuffers.StringOffset _passwordOffset;translator.Get(L, 2, out _passwordOffset);
                    
                    fbs.ReqLoginAccount.AddPassword( _builder, _passwordOffset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndReqLoginAccount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                        FlatBuffers.Offset<fbs.ReqLoginAccount> gen_ret = fbs.ReqLoginAccount.EndReqLoginAccount( _builder );
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
			
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.ByteBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Account(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Account);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Password(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                fbs.ReqLoginAccount gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Password);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
