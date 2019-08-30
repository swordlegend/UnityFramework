using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace gtmGame
{
    public class Dialog
    {
        #region 变量

        private Transform m_rootLayout;
        /// <summary>
        /// obj
        /// </summary>
        public Transform rootDialog
        {
            get { return m_rootLayout; }
        }

        /// <summary>
        /// ui event dict
        /// </summary>
        private Dictionary<UnityEvent, UnityEvent> m_uiEventDict = new Dictionary<UnityEvent, UnityEvent>(32);

        #endregion

        #region 函数

        public void Init(string layoutname)
        {
            GameObject prefab = ResouceLoadHelper.LoadUISync(layoutname);
            if (prefab == null)
                return;

            m_rootLayout = GameObject.Instantiate(prefab).transform;
        }

        public void Close()
        {
            if (m_rootLayout != null)
            {
                GameObject.Destroy(m_rootLayout);
            }

            RemoveAllListener();
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

        public Button FindBtn(Transform parent, string name)
        {
            Transform trans = parent.Find(name);
            if (trans == null)
                return null;

            return trans.GetComponent<Button>();
        }

        public void AddBtnListener(Button btn, UnityAction action)
        {
            btn.onClick.AddListener(action);

            UnityEvent evt = null;
            if (!m_uiEventDict.TryGetValue(btn.onClick, out evt))
            {
                m_uiEventDict.Add(btn.onClick, btn.onClick);
            }
        }

        private void RemoveAllListener()
        {
            foreach (var iter in m_uiEventDict)
            {
                UnityEvent evt = iter.Key;
                if (evt == null)
                    continue;

                evt.RemoveAllListeners();
            }

            m_uiEventDict.Clear();
        }

        #endregion
    }
}
