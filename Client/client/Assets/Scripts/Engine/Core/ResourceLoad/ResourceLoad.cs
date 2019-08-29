using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;

public class ResourceLoad : IResourceLoad
{
    #region 变量

    /// <summary>
    /// 资源目录加载
    /// </summary>
    private ResourcePathLoad m_respathLoad = new ResourcePathLoad();

    /// <summary>
    /// asset bundle加载
    /// </summary>
    private AssetBundleLoad m_assetbundleLoad = new AssetBundleLoad();

    /// <summary>
    /// 资源请求列表
    /// </summary>
    private List<ResourceRequest> m_resreqList = new List<ResourceRequest>(10);

    #endregion

    #region 继承函数

    public override void DoClose()
    {
        
    }

    public override void DoInit()
    {
        
    }

    public override void DoUpdate()
    {
        
    }

    public override object LoadResourceSync(string path, string filename)
    {
        string realpath = path + filename;
        return Resources.Load(realpath);
    }

    public override void LoadResourceAsync(string path, string filename, IResourceLoadCallback callback)
    {
        string realpath = path + filename;
        ResourceRequest resreq = Resources.LoadAsync(realpath);
        m_resreqList.Add(resreq);
    }

    #endregion

    #region 函数



    #endregion
}
