using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    [SerializeField]
    float x_offset;

    [SerializeField]
    float y_offset;
    public Transform player;

    public float moveSpeed = 1f;

    private bool wall = true;

    // Have the wall follow the Player only if Player moves ahead.
    void Update()
    {
        //if (player.position.x - transform.position.x >= 100)
        //{
        //    // transform.position = new Vector3(player.position.x + (float)8 + x_offset, (float)0.57 + y_offset, -10);
        //    transform.position = new Vector3(player.position.x + (float)8, (float)0.9339023, (float)-0.5319953);
        //}
        if (wall == true)
        {
            if (player.position.x - transform.position.x >= (float)200)
            {
                transform.position = new Vector3(player.position.x - (float)8, (float)0.9339023, (float)-0.5319953);
                transform.position += transform.forward * Time.deltaTime * moveSpeed;
            }

            if (player == null)
            {
                wall = false;
            }
        }
    }
}