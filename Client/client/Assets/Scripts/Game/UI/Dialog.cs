using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog
{
    #region 变量

    private GameObject m_obj;
    /// <summary>
    /// obj
    /// </summary>
    public GameObject obj
    {
        get { return m_obj; }
    }

    #endregion

    #region 函数

    public void Init(string dialogname)
    {
        m_obj = ResouceLoadHelper.LoadUISync(dialogname);
    }

    #endregion
}
