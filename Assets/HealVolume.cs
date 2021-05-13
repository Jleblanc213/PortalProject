using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealVolume : MonoBehaviour
{
        public PlayerHealth playerHealth;


        private void Start() => playerHealth.HealDamage(5);


        public void OnTriggerEnter(Collider collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                playerHealth.HealDamage(5);
            }

        }
    }

