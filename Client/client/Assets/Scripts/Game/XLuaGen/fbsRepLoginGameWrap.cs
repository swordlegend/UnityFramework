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
    public class fbsRepLoginGameWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(fbs.RepLoginGame);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__init", _m___init);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "__assign", _m___assign);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ByteBuffer", _g_get_ByteBuffer);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRootAsRepLoginGame", _m_GetRootAsRepLoginGame_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StartRepLoginGame", _m_StartRepLoginGame_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EndRepLoginGame", _m_EndRepLoginGame_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "HashID", fbs.RepLoginGame.HashID);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(fbs.RepLoginGame));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.RepLoginGame constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRootAsRepLoginGame_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.RepLoginGame gen_ret = fbs.RepLoginGame.GetRootAsRepLoginGame( __bb );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<FlatBuffers.ByteBuffer>(L, 1)&& translator.Assignable<fbs.RepLoginGame>(L, 2)) 
                {
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 1, typeof(FlatBuffers.ByteBuffer));
                    fbs.RepLoginGame _obj;translator.Get(L, 2, out _obj);
                    
                        fbs.RepLoginGame gen_ret = fbs.RepLoginGame.GetRootAsRepLoginGame( __bb, _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to fbs.RepLoginGame.GetRootAsRepLoginGame!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m___init(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                fbs.RepLoginGame gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
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
            
            
                fbs.RepLoginGame gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int __i = LuaAPI.xlua_tointeger(L, 2);
                    FlatBuffers.ByteBuffer __bb = (FlatBuffers.ByteBuffer)translator.GetObject(L, 3, typeof(FlatBuffers.ByteBuffer));
                    
                        fbs.RepLoginGame gen_ret = gen_to_be_invoked.__assign( __i, __bb );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartRepLoginGame_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                    fbs.RepLoginGame.StartRepLoginGame( _builder );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EndRepLoginGame_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 1, typeof(FlatBuffers.FlatBufferBuilder));
                    
                        FlatBuffers.Offset<fbs.RepLoginGame> gen_ret = fbs.RepLoginGame.EndRepLoginGame( _builder );
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
			
                fbs.RepLoginGame gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.ByteBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
