using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBoxBottom : MonoBehaviour
{
    public GameObject hazard;
    public GameObject spawnIndicator;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public float xMin, xMax, zMin, zMax;

    

    void Start ()
    {
        StartCoroutine (SpawnWaves ());
    }

    IEnumerator SpawnWaves ()
    {
         yield return new WaitForSeconds (startWait);
         while (true)
         {  
             for (int i = 0; i < hazardCount; i++)
             {
                Vector3 spawnPosition = new Vector3 (Random.Range (-20f,20f), Random.Range (-1f, 1f), Random.Range (-10f, -15f));
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (spawnIndicator, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (1);
                Instantiate (hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
             }
             yield return new WaitForSeconds (waveWait);
         }
    }

}
