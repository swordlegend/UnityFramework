using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gtmInterface
{
    public class IFile
    {
        public static string GetFilePath()
        {
#if UNITY_EDITOR
            return Application.streamingAssetsPath + "/";
#else
            // windows程序
            if (Application.platform == RuntimePlatform.WindowsPlayer)
            {
                return Application.dataPath + "/";
            }

            // mobile程序
            return Application.persistentDataPath + "/";
#endif
        }
    }
}
