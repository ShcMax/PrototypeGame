using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniCamera : MonoBehaviour
{
    public Shader _replShader;
    private Camera MapCam;
    private void Awake()
    {
        _replShader = Shader.Find("Unlit/Texture");
        MapCam = GetComponent<Camera>();
        if (_replShader)
        {
            MapCam.SetReplacementShader(_replShader, "RenderType");
        }


    }

    private void OnDisable()
    {
        MapCam.ResetReplacementShader();
    }
}
