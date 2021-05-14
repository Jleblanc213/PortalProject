using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTransitL : MonoBehaviour
{

    public GameObject rightPortal;
    public GameObject leftPortal;

    public GameObject player;

    public Transform otherPPortal;

    // Start is called before the first frame update


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("coliding");
        PlayerMovement player = other.gameObject.GetComponent<PlayerMovement>();
        if (player != null)
        {
            Debug.Log("player is not null");
            //player.TeleRight();
        }
    }

}