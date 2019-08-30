using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.ComponentModel;

namespace gtmGame
{
    public class Dialog
    {
        #region 变量

        private GameObject m_rootLayout;
        /// <summary>
        /// obj
        /// </summary>
        public GameObject rootDialog
        {
            get { return m_rootLayout; }
        }

        /// <summary>
        /// ui event dict
        /// </summary>
        private HashSet<UnityEvent> m_uiEventSet = new HashSet<UnityEvent>();

        #endregion

        #region 函数

        public void Create(string layoutname)
        {
            GameObject prefab = ResouceLoadHelper.LoadUISync(layoutname);
            if (prefab == null)
                return;

            m_rootLayout = GameObject.Instantiate(prefab);
        }

        public void Close()
        {
            RemoveAllListener();

            if (m_rootLayout != null)
            {
                GameObject.Destroy(m_rootLayout.gameObject);
            }
        }

        public void SetParent(UILayer layer)
        {
            Transform trans = UIManager.instance.GetLayer(layer);
            if (trans == null)
                return;

            if (m_rootLayout == null)
                return;

            m_rootLayout.transform.SetParent(trans, false);
        }

        public void AddBtnClickListener(Button btn, UnityAction action)
        {
            if (btn == null)
                return;

            btn.onClick.AddListener(action);

            if (!m_uiEventSet.Contains(btn.onClick))
            {
                m_uiEventSet.Add(btn.onClick);
            }
        }
        
        private void RemoveAllListener()
        {
            foreach (var iter in m_uiEventSet)
            {
                UnityEvent evt = iter;
                if (evt == null)
                    continue;

                evt.RemoveAllListeners();

                // 解决xlua try to dispose a LuaEnv with C# callback! 报错
                // 参考文章 https://www.bbsmax.com/A/n2d9MjYvdD/
                evt.Invoke();
            }

            m_uiEventSet.Clear();
        }

        private T GetComponentInChild<T>(GameObject parent, string name) where T : UnityEngine.Component
        {
            if (parent == null)
                return null;

            Transform parenttrans = parent.transform;
            if (parenttrans == null)
                return null;

            Transform trans = parenttrans.Find(name);
            if (trans == null)
                return null;

            return trans.GetComponent<T>();
        }

        public Button GetButtonInChild(GameObject parent, string name)
        {
            return GetComponentInChild<Button>(parent, name);
        }

        public Image GetImageInChild(GameObject parent, string name)
        {
            return GetComponentInChild<Image>(parent, name);
        }

        public Text GetTextInChild(GameObject parent, string name)
        {
            return GetComponentInChild<Text>(parent, name);
        }

        #endregion
    }
}
