using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class LoadScrene : MonoBehaviour
{
    public Image loadImage;
    public float loadTransition;
    public Color loadColor;
    public bool loadTrigger;
    public bool endLoad;
    public float loadScreenTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        loadImage.color = loadColor;

        if (loadImage.color.a < 1 && loadTrigger)
        {
            loadColor.a += loadTransition;
        }
        else
        {
            if(endLoad == true)
            {
                loadColor.a -= loadTransition;
            }
        }
    }
    public void NextScene()
    {
        StartCoroutine(StartLoading());
    }

    public IEnumerator StartLoading()
    {
        endLoad = false;
        loadTrigger = true;
        Cursor.lockState = CursorLockMode.Locked;
        yield return new WaitForSeconds(loadScreenTime);
        loadTrigger = false;
        SceneManager.LoadScene("GameplayScene");
        yield return new WaitForSeconds(loadScreenTime);
        endLoad = true;
    }
}
