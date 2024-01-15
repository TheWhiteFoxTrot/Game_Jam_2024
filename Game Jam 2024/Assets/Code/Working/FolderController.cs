using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderController : MonoBehaviour
{
    public GameObject folderContent;
    private bool isFolderOpen = false;

    public void ToggleFolder()
    {
        isFolderOpen = !isFolderOpen;
        folderContent.SetActive(isFolderOpen);
    }
}
