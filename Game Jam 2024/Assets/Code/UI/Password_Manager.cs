using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password_Manager : MonoBehaviour
{

    public GameObject Hide_canvise_GB;
    private bool Hide_Canvise_Bool;

    private InputField InputText;

    // Start is called before the first frame update
    void Start()
    {
        InputText = GetComponent<InputField>();

        Hide_Canvise_Bool = true;
        Hide_canvise_GB.SetActive(Hide_Canvise_Bool);

    }

    public void PasswordChecker()
    {
        switch (InputText.text)
        {
            case "Long Schlong123":
                Hide_Canvise_Bool = false;
                Hide_canvise_GB.SetActive(Hide_Canvise_Bool);
                break;
        }

    }
}
