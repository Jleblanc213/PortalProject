using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{ 
    public PlayerHealth playerHealth;

    


    private void Start() => playerHealth.TakeDamage(5);


    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(5);
        }

    }

    

}
