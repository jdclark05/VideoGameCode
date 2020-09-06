using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EDestroyByContact : MonoBehaviour
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
        if (other.tag == "Boundary")
        {
            return;
        }
        if (other.tag == "Enemy")
        {
            return;
        }
        if (other.tag == "EmptyCapsulesR")
        {
            return;
        }
        if (other.tag == "EmptyCapsulesL")
        {
            return;
        }
        if (other.tag == "NonCollidable")
        {
            return;
        }
        if (other.tag == "Arrow")
        {
            return;
        }
            if (other.tag == "GamePlane")
        {
            return;
        }

        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player" || other.tag == "")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            
        }


        if (other.tag == "Shot")
        { 
             scoreUpdate.AddScore(points);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);

       
        
       
        
    }

    


}
