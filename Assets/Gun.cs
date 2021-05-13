using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update

    public float range = 100f;

    public Camera fpsCam;

    public Rigidbody EnemyRigidbody;

    public Vector3 knockbackPush;

    Vector3 direction = Vector3.zero;
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Environment target = hit.transform.GetComponent<Environment>();

            if (target != null)
            {
                //EnemyRigidbody.velocity = -transform.forward * 8000f;
                direction = Vector3.left * 8000;
                EnemyRigidbody.AddForce(direction * Time.fixedDeltaTime, ForceMode.Acceleration);
                Debug.Log("knockback");
            }

        }
    }




}
