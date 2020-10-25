using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class character_movment : MonoBehaviour
{
    public float speedscal = 5f;
    public float speed = 5f;
  public float jumpSpeed = 8f;
  private float movement = 0f;
  private Rigidbody2D rigidBody;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool grounded;
  // Use this for initialization
  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
  }
  
  // Update is called once per frame
  void Update () {
        grounded = Physics2D.OverlapCircle(groundCheckPoint.position,groundCheckRadius,groundLayer);
    movement = Input.GetAxis ("Horizontal");
    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed * speedscal, rigidBody.velocity.y);
    }
    else if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed* speedscal, rigidBody.velocity.y);
    } 
    else {
      rigidBody.velocity = new Vector2 (0,rigidBody.velocity.y);
    }
    if(Input.GetButtonDown ("Jump")){
      rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
    }
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    }

}

