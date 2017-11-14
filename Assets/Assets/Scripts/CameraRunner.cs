using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunner : MonoBehaviour {
    public Transform player;

    // Have the camera follow the Player.
	void Update () {
        transform.position = new Vector3(player.position.x + (float)8, (float)0.57, -10);
	}
}
