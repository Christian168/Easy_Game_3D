using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_2_Movement : MonoBehaviour
{
    [HideInInspector] public float sidewayForce = -1000f;
    public Rigidbody sphere;

    void Update()
    {
        sphere.AddForce(0, 0, sidewayForce * Time.deltaTime);                    // Applies force to sphere
    }
}
