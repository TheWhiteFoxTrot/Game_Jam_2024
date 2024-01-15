using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Detector : MonoBehaviour
{

    public Sprite Sprite_Switch_on_Trigger;

    public GameObject Target_For_Switch;
    string Target_Name;

    private void Start()
    {
        Debug.Log("Script started!");
        Target_Name = Target_For_Switch.gameObject.name;
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log("Debug: Collision = Active");
        if (collision2D.gameObject.name == Target_Name)
        {
            Debug.Log("Debug: Target_For_Switch = Active");
        }
    }
}
