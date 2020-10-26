using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class character_movment : MonoBehaviour
{
    [SerializeField] private LayerMask platformlayerMask;
    public float speed = 5f;
    public float jumpPower = 8f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;   
    

    private BoxCollider2D boxCollider;

    // Use this for initialization
    void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
        boxCollider = transform.GetComponent<BoxCollider2D>();
  }
  
  // Update is called once per frame
  void Update () {
       

    movement = Input.GetAxis ("Horizontal");
    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }
   
    if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }

        if (isGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpPower);
            
        }
    }
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down , .1f, platformlayerMask);
        UnityEngine.Debug.Log(raycastHit.transform.name);
        return raycastHit.collider != null;
    }

}

