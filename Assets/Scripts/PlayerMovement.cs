using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 myInput;
    public float speed;
    public float rotSpeed;
    public float jumpPower;

    public bool groundContact = false;


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0.1f;

        rb = this.GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {


        myInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        if (groundContact)
        {
            //forwards backwards movement- BE CAREFUL NOT TO BREAK GRAVITY
            rb.velocity = this.transform.forward * myInput.y * speed + Vector3.up * rb.velocity.y;

            rb.angularVelocity = (Vector3.up * myInput.x * rotSpeed);
        }

        //this.transform.position += new Vector3(myInput.x,0,myInput.y)*speed;

        groundContact = false;
    }

    void Update()
    {

        if (Input.GetKeyDown("x") && groundContact)
        {
            rb.velocity += new Vector3(0, jumpPower, 0);
        }


    }

    void OnCollisionStay(Collision collisionData)
    {
        groundContact = true;
    }
}
