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

    public void Exit()
    {
        buttonExit.SetActive(false);
        buttonStart.SetActive(false);
        buttonSaveLoad.SetActive(false);
        buttonCredit.SetActive(false);
        buttonYes.SetActive(true);
        buttonNo.SetActive(true);

        
    }
    public void Saveload()
    {
        buttonExit.SetActive(false);
        buttonStart.SetActive(false);
        buttonSaveLoad.SetActive(false);
        buttonCredit.SetActive(false);
        buttonSlot1.SetActive(true);
        

    }
   
}
