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

    public void Exit()
    {
        CloseAll();
        buttonYes.SetActive(true);
        buttonNo.SetActive(true);

        
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
    }
    public void StartButton()
    {
        CloseAll();
        buttonSlot1.SetActive(true);
        buttonSlot2.SetActive(true);
        buttonSlot3.SetActive(true);
        buttonBack.SetActive(true);
    }
    public void NoButton()
    {
        OpenAll();

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
    }
    public void CreditButton()
    {
        CloseAll();
        buttonCredits.SetActive(true);

    }
    

}
