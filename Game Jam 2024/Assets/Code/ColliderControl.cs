using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderControl : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COllided");
        // Check if the collided object has a name
        if (collision.gameObject.name != null)
        {
            string collidedObjectName = collision.gameObject.name;
            Debug.Log("Collided with: " + collidedObjectName);
        }
        else
        {
            Debug.Log("Collided with an object without a name.");
        }
    }
}
