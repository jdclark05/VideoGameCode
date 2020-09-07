using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    
    
    

   
    

    void OnTriggerEnter(Collider other) 
    {
        //Which colliders object ignores
        if (other.tag != "Enemy")
        {
            return;
        }
       
        //Start explosion if collide with enemy
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Enemy")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            
        }
        Destroy(other.gameObject);
        Destroy(gameObject);


        
        
    
    }

          
}

    




