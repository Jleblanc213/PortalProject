using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float sprintSpeed = 0;

    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 1f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    Rigidbody rb;

    public GameObject RightTP;
    public GameObject LeftTP;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * speed * 4 * Time.deltaTime);
            
        }

        else {
            //velocity.x = 0;
            //velocity.z = 0;
            speed = 12f;

        }


        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }

    public void TeleRight()
    {
        //rb.transform.position = RightTP.transform.position; having a rigid body breaks my game soo can't have this way I guess
    }

    public void TeleLeft()
    {
       // rb.transform.position = RightTP.transform.position;
    }


}
