using UnityEngine;

public class Sphere_1_Collision : MonoBehaviour {

    [HideInInspector] public Sphere_1_Movement sphere_movement_direction;
    [HideInInspector] public float sidewayForce;

    void OnCollisionEnter(Collision collisionInfo) { 

        if (collisionInfo.collider.tag == "Boundary_r") {
            sphere_movement_direction.sidewayForce = sidewayForce*(-1);                 // Reverse force applied on sphere when boundary is hit
        }

        if (collisionInfo.collider.tag == "Boundary_l")
        {   
            sphere_movement_direction.sidewayForce = sidewayForce;                      // Applies force to sphere
        }
    }
}