using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class wasm : MonoBehaviour
{

    private void Awake()
    {
        PlayerSettings.WebGL.memorySize = 2048;
        PlayerSettings.WebGL.emscriptenArgs = "-s WASM_MEM_MAX=512MB";
    }
}
