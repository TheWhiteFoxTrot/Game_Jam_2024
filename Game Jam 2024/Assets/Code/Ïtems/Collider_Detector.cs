using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider_Detector : MonoBehaviour
{

    // Targeting 
    // Adding more objects to trigger upon add a new gameobject name Target_For_Switch_[Letter]
    // Adding a string with name Target_Name_[Letter of Target_For_Switch] 
    // from there on void start conntect Target_Name_[Letter of Target] = Target_For_Switch_[Letter of Target].gameObject.name;

    public bool SummonObject;
    public GameObject objectToSpawn;

    public bool lither;
    private GameObject Prefab;

    public GameObject Target_For_Switch_A;
    string Target_Name_A;
    public Sprite StartAsset;
    public Sprite Transformed;

    public bool NectLevel;

    // Trigger 0 must be always true when starting the program.
    // if more triggers are needed format is Trigger[Number].
    bool Trigger0 = true;
    bool Trigger1 = false;

    private void Start()
    {
        Debug.Log("Script started!");

        this.gameObject.GetComponent<SpriteRenderer>().sprite = StartAsset;
        // Gethering the name of the object for trigger
        Target_Name_A = Target_For_Switch_A.gameObject.name;

    }

    private void Update()
    {
       
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log("Debug: Collision = Active");

        if (Trigger0)
        {

            if (collision2D.gameObject.name == Target_Name_A)
            {
                Debug.Log("Debug: Trigger 1 = Active");
                if (SummonObject)
                {
                    if (lither)
                    {
                        Instantiate(objectToSpawn);
                    }
                    Instantiate(objectToSpawn);
                }
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Transformed;
                // Activating next trigger
                Trigger1 = true;
                Trigger0 = false;

                if (NectLevel)
                {
                    Debug.Log("Next");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
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
