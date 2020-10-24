using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class character_movment : MonoBehaviour
{
    //Movement
    public float movementSpeed = 5f;
    public float jumpSpeed = 10f;
    bool grounded = true;

    private void FixedUpdate()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        float horizontal_speed = horizontalInput * movementSpeed * Time.deltaTime;
        float vertical_speed = verticalInput * jumpSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(horizontal_speed,vertical_speed, 0);
        Debug.Log(transform.position);
    }
    void Update()
    {
        
    }
    //Check if Grounded
    void OnTriggerEnter2D()
    {
        grounded = true;
    }
    void OnTriggerExit2D()
    {
        grounded = false;
    }

    // WIP
    //** private void Flip()
    //{
    // Switch the way the player is labelled as facing.
    //m_FacingRight = !m_FacingRight;
    //
    // Multiply the player's x local scale by -1.
    //  Vector3 theScale = transform.localScale;
    //    theScale.x *= -1;
    //      transform.localScale = theScale;
    //    }

}
