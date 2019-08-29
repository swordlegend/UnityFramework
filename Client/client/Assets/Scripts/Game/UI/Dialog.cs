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

        private GameObject m_rootLayout;
        /// <summary>
        /// obj
        /// </summary>
        public GameObject rootDialog
        {
            get { return m_rootLayout; }
        }

        #endregion

        #region 函数

        public void Init(string layoutname)
        {
            GameObject prefab = ResouceLoadHelper.LoadUISync(layoutname);
            if (prefab == null)
                return;

            m_rootLayout = GameObject.Instantiate(prefab);
        }

        public void Close()
        {
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

        public void AddBtnListener(Button btn, UnityAction action)
        {
            btn.onClick.AddListener(action);
        }

        #endregion
    }
}
