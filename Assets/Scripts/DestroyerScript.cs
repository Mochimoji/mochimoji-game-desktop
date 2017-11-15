using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if Player has entered the Destroyer.
        if (other.tag == "Player")
        {
            Debug.Break();
        }

        // Otherwise, destroy the game object.
        if (other.gameObject.transform.parent)
        {
            Destroy(other.gameObject.transform.parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
