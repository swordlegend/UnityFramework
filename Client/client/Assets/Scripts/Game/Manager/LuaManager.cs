using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using gtmInterface;

namespace gtmGame
{
    public class LuaManager : ClientSingleton<LuaManager>, LogicMgrInterface
    {
        #region 变量

        private XLua.LuaEnv m_luaEnv = null;
        /// <summary>
        /// lua环境
        /// </summary>
        public XLua.LuaEnv luaEnv
        {
            get { return m_luaEnv; }
        }

        #endregion

        #region 继承函数

        public void DoClose()
        {
            if (m_luaEnv != null)
            {
                m_luaEnv.Dispose();
                m_luaEnv = null;
            }
        }

        public void DoInit()
        {
            m_luaEnv = new XLua.LuaEnv();
            m_luaEnv.AddLoader(CustomLoader);
        }

        public void DoUpdate()
        {
            if (m_luaEnv != null)
            {
                m_luaEnv.Tick();
            }
        }

        private byte[] CustomLoader(ref string file)
        {
            string filepath = IFile.GetFilePath() + "/lua/" + file;

            filepath = filepath.Replace(".", "/");

            if (!file.EndsWith(".lua"))
            {
                filepath += ".lua";
            }

            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStream);
            string data = sr.ReadToEnd();
            return  System.Text.Encoding.UTF8.GetBytes(data);
        }

        public void LoadLuaFile(string file)
        {
            if (m_luaEnv != null)
            {
                m_luaEnv.DoString("require ('" + file + "')");
            }
        }

        #endregion
    }
}
