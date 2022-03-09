using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGrid : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 6f);
    }
}
