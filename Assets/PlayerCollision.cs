using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{ 
    public Player_Movement movement;
    //public Player_Movement count_PickUp_collisions;

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Boundary_r")                             // If player hits object classified by string, game restarts
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
                        
        }

        if (collisionInfo.collider.tag == "Boundary_l")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);          
        }


        if (collisionInfo.collider.tag == "obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collisionInfo.collider.tag == "Ziel")
        {
            movement.enabled = false;                                               // Freezes player's position when finished
            Time.timeScale = 0;                                                     // Freezes frame
            UnityEditor.EditorApplication.isPlaying = false;                        // Stops game exectuion in editor 
        }
    }
}

