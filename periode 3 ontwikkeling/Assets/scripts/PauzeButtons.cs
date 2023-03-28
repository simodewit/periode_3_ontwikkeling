using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauzeButtons : MonoBehaviour
{
    public GameObject buttonContinue;
    public GameObject buttonExit;
    public GameObject pauzeText;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            pauzeText.SetActive(true);
            buttonContinue.SetActive(true);
            buttonExit.SetActive(true);

        }

       
    }

    public void ContinuButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauzeText.SetActive(false);
        buttonContinue.SetActive(false);
        buttonExit.SetActive(false);
    }
   
    public void ExitButton()
    {
        pauzeText.SetActive(false);
        buttonContinue.SetActive(false);
        buttonExit.SetActive(false);
    }

}
