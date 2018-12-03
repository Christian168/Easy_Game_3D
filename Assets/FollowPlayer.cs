using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script that ensures camera is following player
public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;                              // Offset, such that camera is not first-person positioned, instead slightly behind player
	
	void Update () {
        transform.position = player.position + offset;  // Updates camera's position for each frame
	}
}
