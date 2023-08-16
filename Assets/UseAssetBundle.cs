using UnityEngine;

public class UseAssetBundle : MonoBehaviour
{
    [SerializeField] private string bundlePath; // Path to asset bundle file

    private void Start()
    {
        LoadAssetBundle();
    }

    private void LoadAssetBundle()
    {
        AssetBundle assetBundle = AssetBundle.LoadFromFile(bundlePath);

        if (assetBundle == null)
        {
            Debug.LogError("Failed to load Asset Bundle.");
            return;
        }

        
        GameObject myPrefab = assetBundle.LoadAsset<GameObject>("Object1");

        
        assetBundle.Unload(false); 
    }
}
