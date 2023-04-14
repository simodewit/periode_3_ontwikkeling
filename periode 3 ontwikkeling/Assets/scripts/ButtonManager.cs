using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonManager : MonoBehaviour
{
    public GameObject buttonExit;
    public GameObject buttonStart;
    public GameObject buttonSaveLoad;
    public GameObject buttonCredit;
    public GameObject buttonYes;
    public GameObject buttonNo;
    public GameObject buttonSlot1;
    public GameObject buttonSlot2;
    public GameObject buttonSlot3;
    public GameObject buttonBack;
    public GameObject buttonCredits;
    public GameObject logo;
    public GameObject exitText;

    public void Exit()
    {
        CloseAll();
        buttonYes.SetActive(true);
        buttonNo.SetActive(true);
        exitText.SetActive(true);
    }

    public void Saveload()
    {
        CloseAll();
        buttonSlot1.SetActive(true);
        buttonSlot2.SetActive(true);
        buttonSlot3.SetActive(true);
        buttonBack.SetActive(true);
    }

    public void Back() { 
        CloseAll();
        buttonExit.SetActive(true );
        buttonStart.SetActive(true);
        buttonSaveLoad.SetActive(true);
        buttonCredit.SetActive(true);
        logo.SetActive(true);
    }

    public void StartButton()
    {
        CloseAll();
        
    }

    public void NoButton()
    {
        OpenAll();
        exitText.SetActive(false);
    }
    public void QuitV()
    {
        Application.Quit();
    }

    private void CloseAll()
    {
        buttonExit.SetActive(false);
        buttonStart.SetActive(false);
        buttonSaveLoad.SetActive(false);
        buttonCredit.SetActive(false);
        buttonYes.SetActive(false);
        buttonNo.SetActive(false);
        buttonSlot1.SetActive(false);
        buttonSlot2.SetActive(false);
        buttonSlot3.SetActive(false);
        buttonBack.SetActive(false);
        buttonCredits.SetActive(false);
        logo.SetActive(false);
    }

    private void OpenAll()
    {
        buttonExit.SetActive(true);
        buttonStart.SetActive(true);
        buttonSaveLoad.SetActive(true);
        buttonCredit.SetActive(true);
        buttonYes.SetActive(false);
        buttonNo.SetActive(false);
        buttonSlot1.SetActive(false);
        buttonSlot2.SetActive(false);
        buttonSlot3.SetActive(false);
        buttonBack.SetActive(false);
        logo.SetActive(true);
    }

    public void CreditButton()
    {
        CloseAll();
        buttonCredits.SetActive(true);
        buttonBack.SetActive(true);
    }
}
