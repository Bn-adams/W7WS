using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    private float horizontalInput;
    private float verticalInput;
    private int MS = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    public void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(MS*horizontalInput, rb.velocity.y, MS*verticalInput);
    }
    public void Action()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

        }
    }
}
