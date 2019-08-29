using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public class UIManager : ClientSingleton<UIManager>, LogicMgrInterface
    {
        #region 变量

        /// <summary>
        /// 对话框
        /// </summary>
        private Dictionary<int, Dialog> m_dialogDict = new Dictionary<int, Dialog>(100);

        #endregion

        #region 继承函数

        public void DoClose()
        {
            
        }

        public void DoInit()
        {
            
        }

        public void DoUpdate()
        {
            
        }

        #endregion

        #region 函数

        public void CreateDialog(string dialogname)
        {
            int hashcode = dialogname.GetHashCode();

            if (m_dialogDict.ContainsKey(hashcode))
                return;

            Dialog dialog = new Dialog();
            dialog.Init(dialogname);
            m_dialogDict.Add(hashcode, dialog);
        }

        #endregion
    }
}

