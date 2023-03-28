using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauzeButtons : MonoBehaviour
{
    public GameObject buttonContinu;
    public GameObject buttonExit;
    public GameObject pauzeText;

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
            pauzeText.SetActive(true);
            buttonContinu.SetActive(true);
            buttonExit.SetActive(true);
            
        }
    }

    public void ContinuButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauzeText.SetActive(false);
        buttonContinu.SetActive(false);
        buttonExit.SetActive(false);
    }
   
    public void ExitButton()
    {
        pauzeText.SetActive(false);
        buttonContinu.SetActive(false);
        buttonExit.SetActive(false);
    }

}