using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour
{

    public string url = "https://lurtistestingstorage.blob.core.windows.net/courses/netcomponents";

    public string assetName = "Floor";
    public Object resultGameObj=null;

    public GameObject objeto = null;
    IEnumerator Start()
    {
        while (!Caching.ready)
            yield return null;
        // Start a download of the given URL
        WWW www = new WWW(url);// WWW.LoadFromCacheOrDownload(url, 2);

        // Wait for download to complete
        yield return www;

        
        // Load and retrieve the AssetBundle
        AssetBundle bundle = www.assetBundle;

        // Load the object asynchronously
        resultGameObj = bundle.LoadAsset(assetName);


        // Unload the AssetBundles compressed contents to conserve memory
        bundle.Unload(false);

        // Frees the memory from the web stream
        www.Dispose();

        objeto = GameObject.Find("Cube");
    }

    public void Update()
    {
        if (resultGameObj != null && objeto!=null)
        {
            objeto.GetComponent<Texturize>().Texturiza(resultGameObj as Material);
            objeto = null;
        }
    }
}
