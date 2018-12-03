using UnityEngine;

public class Sphere_2_Collision : MonoBehaviour
{
    public Sphere_2_Movement sphere_movement_direction;
    [HideInInspector] public float sidewayForce;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Boundary_r")
        {
            sphere_movement_direction.sidewayForce = sidewayForce;                  // Applies force to sphere
        }

        if (collisionInfo.collider.tag == "Boundary_l")
        {
            sphere_movement_direction.sidewayForce = sidewayForce * (-1);           // Reverse force applied on sphere when boundary is hit
        }
    }
}