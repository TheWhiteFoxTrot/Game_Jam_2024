using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Detector : MonoBehaviour
{

    // Targeting 
    // Adding more objects to trigger apone add a new gameobject name Target_For_Switch_[Letter]
    // Adding a string with name Target_Name_[Letter of Target_For_Switch] 
    // from there on void start conntect Target_Name_[Letter of Target] = Target_For_Switch_[Letter of Target].gameObject.name;

    public GameObject Target_For_Switch_A;
    string Target_Name_A;


    // Trigger 0 must be always true when starting the program.
    // if more triggers are needed format is Trigger[Number].
    bool Trigger0 = true;
    bool Trigger1 = false;

    private void Start()
    {
        Debug.Log("Script started!");

        // Gethering the name of the object for trigger
        Target_Name_A = Target_For_Switch_A.gameObject.name;
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log("Debug: Collision = Active");

        if (Trigger0)
        {
            if (collision2D.gameObject.name == Target_Name_A)
            {
                Debug.Log("Debug: Trigger 1 = Active");

                // Asset switch 

                // Activating next trigger
                Trigger1 = true;
                Trigger0 = false;
            }
            else if (Trigger1)
            {
                Debug.Log("Debug: Trigger 2 = Active");

                // Asset switch 

                // Activating next trigger
                Trigger1 = false;
            }
        }
    }
}
