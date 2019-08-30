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
    public class gtmGameDialogWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(gtmGame.Dialog);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Create", _m_Create);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParent", _m_SetParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddBtnClickListener", _m_AddBtnClickListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetButtonInChild", _m_GetButtonInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetImageInChild", _m_GetImageInChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTextInChild", _m_GetTextInChild);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootDialog", _g_get_rootDialog);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					gtmGame.Dialog gen_ret = new gtmGame.Dialog();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to gtmGame.Dialog constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _layoutname = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Create( _layoutname );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetParent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    gtmGame.UILayer _layer;translator.Get(L, 2, out _layer);
                    
                    gen_to_be_invoked.SetParent( _layer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddBtnClickListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.UI.Button _btn = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
                    UnityEngine.Events.UnityAction _action = translator.GetDelegate<UnityEngine.Events.UnityAction>(L, 3);
                    
                    gen_to_be_invoked.AddBtnClickListener( _btn, _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetButtonInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.Button gen_ret = gen_to_be_invoked.GetButtonInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetImageInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.Image gen_ret = gen_to_be_invoked.GetImageInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTextInChild(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GameObject _parent = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        UnityEngine.UI.Text gen_ret = gen_to_be_invoked.GetTextInChild( _parent, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rootDialog(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                gtmGame.Dialog gen_to_be_invoked = (gtmGame.Dialog)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rootDialog);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
