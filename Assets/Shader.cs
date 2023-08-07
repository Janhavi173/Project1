using UnityEngine;

public class Shader : MonoBehaviour
{
    public Material unlitMaterial;
    public Material standardMaterial;
    public Material transparentMaterial;
    public Material outlineMaterial;

    private Renderer objectRenderer;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>();

        // Make sure you have assigned materials to the script component in the Inspector.
        if (unlitMaterial == null || standardMaterial == null)
        {
            Debug.LogError("Error!");
            enabled = false; // Disable the script if the materials are not assigned properly.
        }
    }

    private void Update()
    {
        // Check for key presses and switch materials accordingly.
        if (Input.GetKeyDown(KeyCode.A))
        {
            SwitchToUnlitMaterial();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            SwitchToStandardMaterial();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            SwitchToTransparentMaterial();
        }
    }

    private void SwitchToUnlitMaterial()
    {
        objectRenderer.material = unlitMaterial;
    }

    private void SwitchToStandardMaterial()
    {
        objectRenderer.material = standardMaterial;
    }

    private void SwitchToTransparentMaterial()
    {
        objectRenderer.material = transparentMaterial;
    }
}