using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FolderController : MonoBehaviour
{
    public GameObject FolderContent_A;
    public GameObject FolderContent_B;

    public bool isFolderOpen_A;
    public bool isFolderOpen_B;


    private void Start()
    {
        Debug.Log("DEBUG : NOTEPAD : CODE ACTIVE");

        // Deactivate on Start
        FolderContent_A.SetActive(isFolderOpen_A);
        FolderContent_B.SetActive(isFolderOpen_B);
    }

    public void ToggleFolder()
    {
        Debug.Log("DEBUG : NOTEPAD : FOLDER TOGGELD");

        // When pressed ether shows or hides window
        isFolderOpen_A = !isFolderOpen_A;
        FolderContent_A.SetActive(isFolderOpen_A);

        isFolderOpen_B = !isFolderOpen_B;
        FolderContent_B.SetActive(isFolderOpen_B);
    }
}
