using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    Shader shader1;
    Shader shader2;
    Shader shader3;
    Renderer rend;

    public Texture newTexture; // Texture to apply to the shader

    void Start()
    {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("Standard");
        shader2 = Shader.Find("Unlit/Color");
        shader3 = Shader.Find("Unlit/Transparent");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rend.material.shader = shader1;
            rend.material.SetColor("_Color", rend.material.color); 
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rend.material.shader = shader2;
            rend.material.SetColor("_Color", rend.material.color);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rend.material.shader = shader3;
            
        }
    }
}
