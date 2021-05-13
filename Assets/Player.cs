using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            playerHealth.TakeDamage(5);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
