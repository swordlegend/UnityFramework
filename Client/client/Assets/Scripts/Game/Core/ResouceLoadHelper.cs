using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using gtmInterface;

public static class ResouceLoadHelper
{
    private const string UIPath = "ui/uiprefab/";

    public static GameObject LoadUISync(string filename)
    {
        if (IResourceLoad.instance != null)
        {
            return (GameObject)IResourceLoad.instance.LoadResourceSync(UIPath, filename);
        }

        return null;
    }

    public static void LoadUIAsync(string filename, IResourceLoadCallback callback)
    {
        if (IResourceLoad.instance != null)
        {
            IResourceLoad.instance.LoadResourceAsync(UIPath, filename, callback);
        }
    }
}
