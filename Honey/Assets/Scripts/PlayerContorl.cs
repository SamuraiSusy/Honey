using UnityEngine;
using System.Collections;

public class PlayerContorl : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public float raySize; // muuta pelaajan spriten koon mukaan
    private bool isGrounded;

	// Use this for initialization
	private void Start () 
    {
	
	}
	
	// Update is called once per frame
	private void Update ()
    {
        DebugRaycast();
	}

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float move = h * speed * Time.deltaTime;

        transform.Translate(new Vector3(move, 0));
    }

    private void Jump()
    {
        float v = Input.GetAxis("Jump");
        float jump = v * jumpForce * Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, raySize);

        if (hit != null)
            isGrounded = true;
        else
            isGrounded = false;

        if(isGrounded)
            transform.Translate(new Vector3(0, jump));
    }

    private void DebugRaycast()
    {
        Debug.DrawRay(transform.position, -Vector3.up * raySize);
        Debug.Log("is grounded " + isGrounded);
    }
}
