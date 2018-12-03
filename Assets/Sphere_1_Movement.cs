using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_1_Movement : MonoBehaviour {

    [HideInInspector] public float sidewayForce = 2000f;
    public Rigidbody sphere;

	void Update () {
        sphere.AddForce(0, 0, -sidewayForce * Time.deltaTime);              // Applies force to sphere
    }
}
