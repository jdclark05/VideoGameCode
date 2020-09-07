using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject playerPrefab;
    GameObject playerInstance;

    float respawnTimer;

    // Use this for initialization
    void Start ()
    {
        if (playerInstance != null)
        {
            return;
        }

    }


    void Update()
    {
        if (playerInstance == null)
        {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }
    }

    void SpawnPlayer()
    {
    	respawnTimer = 1;
    	playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "PlayerModel";
    }

    
}




