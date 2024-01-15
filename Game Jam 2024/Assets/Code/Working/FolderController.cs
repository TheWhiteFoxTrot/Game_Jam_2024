using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderController : MonoBehaviour
{
    public GameObject folderContent;
    private bool isFolderOpen;

    private void Start()
    {
        // Deactivate on Start
        folderContent.SetActive(isFolderOpen);
    }

    public void ToggleFolder()
    {
        // When pressed ether shows or hides window
        isFolderOpen = !isFolderOpen;
        folderContent.SetActive(isFolderOpen);
    }
}
