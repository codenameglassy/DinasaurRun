using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public float zSpawn;
    public float tileLength = 32.4f;

    public Transform playerTransform;

    public GameObject[] grounds;
 

    private void Awake()
    {
       
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 300;
    }

    private void Update()
    {
        if(playerTransform == null)
        {
            return;
        }


        if (playerTransform.position.x > zSpawn - tileLength)
        {
            SpawnNext();
            SpawnNext();
         
            //CollectableSpawnerManager.instance.SpawnCollectable();
        }
    }


    public void SpawnNext()
    {
        GameObject mountain = grounds[Random.Range(0, grounds.Length)];
        Instantiate(mountain, transform.right * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }



}
