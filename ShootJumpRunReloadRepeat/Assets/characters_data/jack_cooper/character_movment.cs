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
    //public float jumpPower = 8f;
    private float movementx = 0f;
    private float movementy = 0f;
    private Rigidbody2D rigidBody;
    //private bool m_FacingRight = true;
    //private bool doubleJump = true;
    private BoxCollider2D boxCollider;

    // Use this for initialization
    void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
        boxCollider = transform.GetComponent<BoxCollider2D>();

  }

    // Update is called once per frame
    void Update()
    {

        //TOOO MANY FUCKING IFFFFFFFFFFFFFFFFFFFFFFFFFFFFs
        //we have to be more object oriented :>
        //Horizontal movement
        movementx = Input.GetAxis("Horizontal");
        if (movementx > 0f)
        {
            rigidBody.velocity = new Vector2(movementx * speed, rigidBody.velocity.y);
        }

        if (movementx < 0f)
        {
            rigidBody.velocity = new Vector2(movementx * speed, rigidBody.velocity.y);
        }

        movementy = Input.GetAxis("Vertical");
        if (movementy > 0f)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movementy * speed);
        }

        if (movementy < 0f)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, movementy * speed);
        }

        // Jumping

        //    if (isGrounded())
        //    {
        //        doubleJump = true;
        //    }
        //
        //    if (Input.GetKeyDown(KeyCode.Space))
        //    {
        //        if (isGrounded()) {
        //            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpPower);
        //        }
        //       else
        //       if(doubleJump)
        //       {                   //WHY ARE YOU NOT WORKING YOU PIECE OF SHIT !!!
        //           rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpPower);
        //           doubleJump = false;
        //       }
        //   }

        //   if (isGrounded() && Input.GetKeyDown(KeyCode.LeftControl))
        //   {
        //      boxCollider.enabled = false;
        //   }
        ///  else
        ///  {
        ///      boxCollider.enabled = true;
        ///   }

        // If the input is moving the player right and the player is facing left...
        //   if (movement > 0 && !m_FacingRight)
        //   {
        // ... flip the player.
        //      Flip();
        //  }
        // Otherwise if the input is moving the player left and the player is facing right...
        //  else if (movement < 0 && m_FacingRight)
        //  {
        // ... flip the player.
        //      Flip();
        //  }
        //  }
        // private bool isGrounded()
        // {
        //     RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down , .1f, platformlayerMask);
        //     UnityEngine.Debug.Log(raycastHit.transform.name);
        //     return raycastHit.collider != null;
        // }


        //private void Flip()
        // {
        //     // Switch the way the player is labelled as facing.
        //     m_FacingRight = !m_FacingRight;
        //
        // Multiply the player's x local scale by -1.
        //     Vector3 theScale = transform.localScale;
        //     theScale.x *= -1;
        //    transform.localScale = theScale;
        //}
    }
}


