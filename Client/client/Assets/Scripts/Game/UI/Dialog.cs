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



        private bool m_bVisible = true;
        /// <summary>
        /// 可见性s
        /// </summary>
        public bool visible
        {
            get { return m_bVisible; }
        }



        /// <summary>
        /// lua回调(界面显示)
        /// </summary>
        private LuaFunction m_preShow = new LuaFunction();

        /// <summary>
        /// lua回调(界面隐藏)
        /// </summary>
        private LuaFunction m_preHide = new LuaFunction();

        /// <summary>
        /// lua回调(界面关闭)
        /// </summary>
        private LuaFunction m_preClose = new LuaFunction();



        /// <summary>
        /// ui event dict
        /// </summary>
        private HashSet<UnityEvent> m_uiEventSet = new HashSet<UnityEvent>();

        #endregion

        #region 函数

        public void Create(string layoutname, string tablename)
        {
            GameObject prefab = ResouceLoadHelper.LoadUISync(layoutname);
            if (prefab == null)
                return;

            m_rootLayout = GameObject.Instantiate(prefab);

            InitAllLuaCallFunc(tablename);
        }

        public void Close()
        {
            if (m_preClose != null)
                m_preClose.Call<int>(0);

            CloseAllLuaCallFunc();
            RemoveAllListener();

            if (m_rootLayout != null)
            {
                GameObject.Destroy(m_rootLayout.gameObject);
            }
        }

        private void CloseAllLuaCallFunc()
        {
            m_preShow.Close();
            m_preHide.Close();
            m_preClose.Close();
        }

        private void InitAllLuaCallFunc(string tablename)
        {
            m_preShow.InitFunction(tablename, "preShow");
            m_preHide.InitFunction(tablename, "preHide");
            m_preClose.InitFunction(tablename, "preClose");
        }

        public void SetVisible(bool visible)
        {
            if (visible)
            {
                if (m_bVisible != visible)
                {
                    m_bVisible = visible;

                    if (m_preShow != null)
                    {
                        m_preShow.Call<int>(0);
                    }

                    m_rootLayout.SetActive(true);
                }
            }
            else
            {
                if (m_bVisible != visible)
                {
                    m_bVisible = visible;

                    if (m_preHide != null)
                    {
                        m_preHide.Call<int>(0);
                    }

                    m_rootLayout.SetActive(false);
                }
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

        public InputField GetInputFieldInChild(GameObject parent, string name)
        {
            return GetComponentInChild<InputField>(parent, name);
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

        public void SetInteractable(Selectable selectable, bool interactable)
        {
            if (selectable == null)
                return;

            selectable.interactable = interactable;
        }

        #endregion
    }
}
