using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTransitR : MonoBehaviour
{
    public GameObject otherPortal;
    public GameObject rightPortal;
    public GameObject leftPortal;

    public Transform otherPPortal;

    // Start is called before the first frame update
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("coliding");
       // PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();

        if (other.tag == "Player")
        {
            other.transform.position = otherPortal.transform.position + otherPortal.transform.forward *1;
        }

       //if (player != null)
        //{
           // Debug.Log("player is not null");
            //player.TeleLeft(); 
        //}
    }

}
