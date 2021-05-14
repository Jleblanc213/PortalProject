using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPortal : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject leftPortal;
    public GameObject rightPortal;

    GameObject mainCamera;
    GameObject environment;

    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            ShootPortal(leftPortal);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            ShootPortal(rightPortal);
        }

    }

    public void ShootPortal(GameObject portal)
    {
        int x = Screen.width / 2;
        int y = Screen.height / 2;
        RaycastHit hit;
        if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit))
        {
            Quaternion hitObjectRotation = Quaternion.LookRotation(hit.normal);
            portal.transform.position = hit.point;
            portal.transform.rotation = hitObjectRotation;

        }
    }

}
