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
        private HashSet<UnityEvent> m_uiEventSet = new HashSet<UnityEvent>();

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
            RemoveAllListener();

            if (m_rootLayout != null)
            {
                GameObject.Destroy(m_rootLayout);
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

        public Button FindBtn(Transform parent, string name)
        {
            Transform trans = parent.Find(name);
            if (trans == null)
                return null;

            return trans.GetComponent<Button>();
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

        public void RemoveAllBtnClickListener(Button btn)
        {
            if (btn == null)
                return;

            btn.onClick.RemoveAllListeners();

            if (m_uiEventSet.Contains(btn.onClick))
            {
                m_uiEventSet.Remove(btn.onClick);
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
                evt = null;
            }

            m_uiEventSet.Clear();
        }

        #endregion
    }
}
