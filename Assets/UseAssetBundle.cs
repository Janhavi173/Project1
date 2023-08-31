using UnityEngine;

public class UseAssetBundle : MonoBehaviour
{
    public string assetBundlePath;

    private AssetBundle assetBundle;

    void Start()
    {

        assetBundle = AssetBundle.LoadFromFile(assetBundlePath);

        if (assetBundle == null)
        {
            Debug.LogError("Failed to load asset bundle!");
            return;
        }

        InstantiateFromAssetBundle();
    }

    void InstantiateFromAssetBundle()
    {

        GameObject prefab = assetBundle.LoadAsset<GameObject>("Object1");
        Instantiate(prefab);
    }

    void OnDestroy()
    {

        if (assetBundle != null)
        {
            assetBundle.Unload(false);
        }
    }
}

