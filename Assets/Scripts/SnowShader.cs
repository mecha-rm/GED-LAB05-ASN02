using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowShader : MonoBehaviour
{
    public Material material;
    private Shader shader;
    private Texture texture;

    // Start is called before the first frame update
    void Start()
    {
        if (material != null)
        {
            shader = material.shader;
            texture = material.mainTexture;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
