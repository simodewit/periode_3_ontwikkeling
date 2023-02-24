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
    public void Exit()
    {
        buttonExit.SetActive(false);
        buttonStart.SetActive(false);
        buttonSaveLoad.SetActive(false);
        buttonCredit.SetActive(false);
        buttonYes.SetActive(true);
        buttonNo.SetActive(true);

        
    }
   
}
