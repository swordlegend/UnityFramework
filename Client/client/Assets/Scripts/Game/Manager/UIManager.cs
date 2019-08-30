using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmGame
{
    public enum UILayer
    {
        main,
        tips,
        loading,
    }

    public class UIManager : ClientSingleton<UIManager>, LogicMgrInterface
    {
        #region 变量

        /// <summary>
        /// 对话框
        /// </summary>
        private Dictionary<int, Dialog> m_dialogDict = new Dictionary<int, Dialog>(100);

        /// <summary>
        /// 
        /// </summary>
        private Dictionary<UILayer, Transform> m_layerdict = new Dictionary<UILayer, Transform>(8);

        #endregion

        #region 继承函数

        public void DoClose()
        {
            foreach(var iter in m_dialogDict)
            {
                Dialog dialog = iter.Value;
                if (dialog == null)
                    continue;

                dialog.Close();
            }

            m_dialogDict.Clear();
        }

        public void DoInit()
        {
            InitLayer();
        }

        public void DoUpdate()
        {

        }

        #endregion

        #region 函数

        private void InitLayer()
        {
            Transform uiroot = GameObject.Find("uiroot").transform;
            if (uiroot != null)
            {
                m_layerdict.Add(UILayer.main, uiroot.Find(UILayer.main.ToString()));
                m_layerdict.Add(UILayer.tips, uiroot.Find(UILayer.tips.ToString()));
                m_layerdict.Add(UILayer.loading, uiroot.Find(UILayer.loading.ToString()));
            }
        }

        public Transform GetLayer(UILayer layer)
        {
            Transform trans;
            if (m_layerdict.TryGetValue(layer, out trans))
            {
                return trans;
            }

            return null;
        }

        public Dialog CreateDialog(string layoutname, string luafilename)
        {
            int hashcode = layoutname.GetHashCode();

            if (m_dialogDict.ContainsKey(hashcode))
                return m_dialogDict[hashcode];

            Dialog dialog = new Dialog();
            dialog.Init(layoutname);
            dialog.SetParent(UILayer.main);
            m_dialogDict.Add(hashcode, dialog);
            return dialog;
        }

        public void CloseDialog(string layoutname)
        {
            int hashcode = layoutname.GetHashCode();

            Dialog dialog = null;
            if (m_dialogDict.TryGetValue(hashcode, out dialog))
            {
                if (dialog != null)
                {
                    dialog.Close();
                }
            }

            m_dialogDict.Remove(hashcode);
        }

        #endregion
    }
}

