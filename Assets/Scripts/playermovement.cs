using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Vector3 jump;
    public Rigidbody rb;

    public bool isGrounded;

    public float jumpforce = 5.0f;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    private void Start()
    {
        rb.AddForce(0, 200, 500);
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("w") && isGrounded)
        {
            rb.AddForce(jump * jumpforce, ForceMode.Impulse);
            isGrounded = false;
        }

    }
}
