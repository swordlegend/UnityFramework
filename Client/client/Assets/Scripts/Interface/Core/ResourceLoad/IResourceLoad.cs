using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public delegate void IResourceLoadCallback(object go);

    public abstract class IResourceLoad : IManager
    {
        protected static IResourceLoad m_sInstance = null;

        public IResourceLoad()
        {
            m_sInstance = this;
        }

        public static IResourceLoad instance
        {
            get { return m_sInstance; }
        }

        /// <summary>
        /// 同步加载资源
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public abstract object LoadResourceSync(string path, string filename);

        /// <summary>
        /// 异步加载资源
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public abstract void LoadResourceAsync(string path, string filename, IResourceLoadCallback callback);
    }
}
