using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;

    
    private ScoreUpdate scoreUpdate;
    public int points;
    
    

    void Start ()
    {
        scoreUpdate = GameObject.FindWithTag("Canvas").GetComponent<ScoreUpdate> ();
    }

    

    public void OnTriggerEnter(Collider other) 
    {
        //If object tag is anything but "Player" do not instantiate explosion
        if (other.tag != "Player")
        {
            return;
        }
        
        //If object is the "Player" instantiate explosion
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player" || other.tag == "Shot")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            
        }

        //Add to player score if explosion instantiated by "Shot"
        if (other.tag == "Shot")
        { 
             scoreUpdate.AddScore(points);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);

       
        
       
        
    }

    


}
