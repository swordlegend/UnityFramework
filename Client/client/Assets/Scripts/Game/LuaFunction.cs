using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua.LuaDLL;

namespace gtmGame
{
    public class LuaFunction
    {
        private XLua.LuaFunction m_luaFunction = null;

        public void Close()
        {
            if (m_luaFunction != null)
            {
                m_luaFunction.Dispose();
                m_luaFunction = null;
            }
        }

        public void InitFunction(string tablename, string funcname)
        {
            if (!string.IsNullOrEmpty(funcname))
            {
                XLua.LuaEnv luaenv = LuaManager.instance.luaEnv;
                IntPtr L = luaenv.L;
                if (string.IsNullOrEmpty(tablename))
                {
                    m_luaFunction = luaenv.Global.Get<XLua.LuaFunction>(funcname);
                }
                else
                {
                    int oldtop = Lua.lua_gettop(L);
                    Lua.xlua_getglobal(L, tablename);
                    if (Lua.lua_istable(L, -1))
                    {
                        Lua.lua_pushstring(L, funcname);
                        if (Lua.xlua_pgettable(L, -2) != 0)
                        {
                            string err = Lua.lua_tostring(L, -1);
                            Lua.lua_settop(L, oldtop);
                            throw new Exception("get field [" + funcname + "] error:" + err);
                        }

                        try
                        {
                            luaenv.translator.Get(L, -1, out m_luaFunction);
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        finally
                        {
                            Lua.lua_settop(L, oldtop);
                        }
                    }
                }
            }
        }

        public void Call<T>(T a)
        {
            m_luaFunction.Action(a);
        }
    }
}

