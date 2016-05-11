using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{

    public string url = "https://lurtistestingstorage.blob.core.windows.net/courses/escenario";

    
    public string resultGameObj;

    

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(LoadScene());
        }
    }
    IEnumerator LoadScene()
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
        resultGameObj = bundle.GetAllScenePaths()[0];


        // Unload the AssetBundles compressed contents to conserve memory
        

        SceneManager.LoadSceneAsync(resultGameObj);
        bundle.Unload(false);

        // Frees the memory from the web stream
        www.Dispose();

    }
}
