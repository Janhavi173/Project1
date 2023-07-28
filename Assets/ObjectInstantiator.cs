using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiator : MonoBehaviour
{
    public List<GameObject> modelsToSpawn;
    private GameObject currentModel;

    void Start()
    {
       //empty screen
        currentModel = null;
    }

    void Update()
    {
        // Check for key presses
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SpawnModel(0);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnModel(1);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            SpawnModel(2);
        }
    }

    void SpawnModel(int index)
    {
        
        if (currentModel != null)
        {
            Destroy(currentModel);
        }

        if (index >= 0 && index < modelsToSpawn.Count)
        {
            // Spawn the selected model 
            currentModel = Instantiate(modelsToSpawn[index], transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Invalid model index: " + index);
        }
    }
}