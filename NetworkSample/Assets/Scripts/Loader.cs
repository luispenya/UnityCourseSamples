using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour
{

    public string url = "http://lurtis.com/netcomponent";

    public string assetName = "Floor";
    public Object resultGameObj;
    IEnumerator Start()
    {
        while (!Caching.ready)
            yield return null;
        // Start a download of the given URL
        WWW www = WWW.LoadFromCacheOrDownload(url, 1);

        // Wait for download to complete
        yield return www;

        // Load and retrieve the AssetBundle
        AssetBundle bundle = www.assetBundle;

        // Load the object asynchronously
        AssetBundleRequest request = bundle.LoadAsset(assetName, typeof(GameObject));

        // Wait for completion
        yield return request;

        // Get the reference to the loaded object
        GameObject obj = request.asset as GameObject;

        // Unload the AssetBundles compressed contents to conserve memory
        bundle.Unload(false);

        // Frees the memory from the web stream
        www.Dispose();
    }
}
