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
    public class gtmGameAnimStateFactoryWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(gtmGame.AnimStateFactory);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateStateMgr", _m_CreateStateMgr_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					gtmGame.AnimStateFactory gen_ret = new gtmGame.AnimStateFactory();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to gtmGame.AnimStateFactory constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateStateMgr_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<gtmGame.Npc>(L, 1)) 
                {
                    gtmGame.Npc _npc = (gtmGame.Npc)translator.GetObject(L, 1, typeof(gtmGame.Npc));
                    
                        gtmGame.AnimStateMgr gen_ret = gtmGame.AnimStateFactory.CreateStateMgr( _npc );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<gtmGame.Mount>(L, 1)) 
                {
                    gtmGame.Mount _mount = (gtmGame.Mount)translator.GetObject(L, 1, typeof(gtmGame.Mount));
                    
                        gtmGame.AnimStateMgr gen_ret = gtmGame.AnimStateFactory.CreateStateMgr( _mount );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<gtmGame.Character>(L, 1)) 
                {
                    gtmGame.Character _cha = (gtmGame.Character)translator.GetObject(L, 1, typeof(gtmGame.Character));
                    
                        gtmGame.AnimStateMgr gen_ret = gtmGame.AnimStateFactory.CreateStateMgr( _cha );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<gtmGame.MainCharacter>(L, 1)) 
                {
                    gtmGame.MainCharacter _cha = (gtmGame.MainCharacter)translator.GetObject(L, 1, typeof(gtmGame.MainCharacter));
                    
                        gtmGame.AnimStateMgr gen_ret = gtmGame.AnimStateFactory.CreateStateMgr( _cha );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to gtmGame.AnimStateFactory.CreateStateMgr!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
