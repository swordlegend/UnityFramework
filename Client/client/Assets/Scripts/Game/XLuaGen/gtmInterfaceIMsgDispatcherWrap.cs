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
    public class gtmInterfaceIMsgDispatcherWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(gtmInterface.IMsgDispatcher);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RegisterMsgType", _m_RegisterMsgType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispatcher", _m_Dispatcher);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendFBMsg", _m_SendFBMsg);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "flatBufferBuilder", _g_get_flatBufferBuilder);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "instance", _g_get_instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "gtmInterface.IMsgDispatcher does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterMsgType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmInterface.IMsgDispatcher gen_to_be_invoked = (gtmInterface.IMsgDispatcher)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    gtmInterface.IMsgType _msgtype;translator.Get(L, 2, out _msgtype);
                    
                    gen_to_be_invoked.RegisterMsgType( _msgtype );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispatcher(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmInterface.IMsgDispatcher gen_to_be_invoked = (gtmInterface.IMsgDispatcher)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ulong _msgid = LuaAPI.lua_touint64(L, 2);
                    byte[] _bytearray = LuaAPI.lua_tobytes(L, 3);
                    
                    gen_to_be_invoked.Dispatcher( _msgid, _bytearray );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendFBMsg(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmInterface.IMsgDispatcher gen_to_be_invoked = (gtmInterface.IMsgDispatcher)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    ulong _msgid = LuaAPI.lua_touint64(L, 2);
                    FlatBuffers.FlatBufferBuilder _builder = (FlatBuffers.FlatBufferBuilder)translator.GetObject(L, 3, typeof(FlatBuffers.FlatBufferBuilder));
                    
                    gen_to_be_invoked.SendFBMsg( _msgid, _builder );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, gtmInterface.IMsgDispatcher.instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_flatBufferBuilder(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                gtmInterface.IMsgDispatcher gen_to_be_invoked = (gtmInterface.IMsgDispatcher)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.flatBufferBuilder);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
