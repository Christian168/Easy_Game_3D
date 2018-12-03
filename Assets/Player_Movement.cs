using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour {

    public Rigidbody rb;
    public Text count_PickUp_Collisions;
    private int count_collisions;

    [HideInInspector] public float forwardForce = 700f;             // Initialize forces, HideInInspector used to ensure same values in each iteration
    [HideInInspector] public float sidewayForce = 500f;

    private void Start()
    {
        count_collisions = 0;                                       // Initialize count-variable for collisions
        //SetCountCollisions();                                       // Converts int to string to display the value of the variable
    }

    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);           // Time.deltaTime the amount of time expired since the computer drew the last frame

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0 , 0, -sidewayForce * Time.deltaTime);     // Moves right according to value of sidewayForce
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0, 0, sidewayForce * Time.deltaTime);       // Moves right according to value of sidewayForce
        }
    }

    void OnTriggerEnter(Collider other)                             // if-case: If object is triggered 
    {
        Destroy(other.gameObject);                                  // Destroy object that is hit
        count_collisions = count_collisions + 1;                    // Increment counter once object is hit
        SetCountCollisions();                                       // Adjust output according to incrementation
    }

    void SetCountCollisions()                                       // Function to update count value 
    {
        count_PickUp_Collisions.text = "Count:" + count_collisions.ToString();
    }
}
