using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password_Manager : MonoBehaviour
{

    public GameObject Hide_canvise_GB;
    private bool Hide_Canvise_Bool;

    public GameObject Wrong_Password_GB;
    private bool Wrong_Password_Bool;

    private InputField InputText;

    // Start is called before the first frame update
    void Start()
    {
        InputText = GetComponent<InputField>();

        Hide_Canvise_Bool = true;
        Hide_canvise_GB.SetActive(Hide_Canvise_Bool);

        Wrong_Password_Bool = true;
        Wrong_Password_GB.SetActive(Hide_Canvise_Bool);
    }

    public void PasswordChecker()
    {
        switch (InputText.text)
        {
            case "PP56":
                Hide_Canvise_Bool = false;
                Hide_canvise_GB.SetActive(Hide_Canvise_Bool);
                break;

            case "":
                Wrong_Password_Bool = false;
                Wrong_Password_GB.SetActive(Hide_Canvise_Bool);
                break;
        }

    }
}
