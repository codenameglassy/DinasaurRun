using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public float zSpawn;
    public float tileLength;

    public Transform playerTransform;

    public GameObject[] grounds;
    public int numberOfTiles;

    private void Awake()
    {

        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 300;
    }

    private void Update()
    {
        if (playerTransform == null)
        {
            return;
        }


        if (playerTransform.position.x - 19 > zSpawn - (numberOfTiles * tileLength))
        {
            SpawnNext();
            SpawnNext();
            SpawnNext();
            SpawnNext();
        }
    }



    public void SpawnNext()
    {

        GameObject mountain = grounds[Random.Range(0, grounds.Length)];
        Instantiate(mountain, transform.right * zSpawn, transform.rotation);
        zSpawn += tileLength;
    }



}
