using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    public PlayerMec playerMec;

    public GameObject player;
    private int boostCheckInt;
    public Vector3 playerPositionData;

    public int slot;

    public void SaveGame()
    {
        slot = PlayerPrefs.GetInt("SlotNumber");

        if (playerMec.checkIfBoosting == true)
        {
            boostCheckInt = 1;
        }
        else
        {
            boostCheckInt = 0;
        }

        PlayerPrefs.SetFloat("PlayerPositionX" + slot, player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerPositionY" + slot, player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerPositionZ" + slot, player.transform.position.z);

        PlayerPrefs.SetInt("BoostCheck" + slot, boostCheckInt);
        PlayerPrefs.SetFloat("JumpBoostCheck" + slot, playerMec.jumpBoost);
    }
    public void LoadGame()
    {
        slot = PlayerPrefs.GetInt("SlotNumber");

        playerPositionData.x = PlayerPrefs.GetFloat("PlayerPositionX" + slot);
        playerPositionData.y = PlayerPrefs.GetFloat("PlayerPositionY" + slot);
        playerPositionData.z = PlayerPrefs.GetFloat("PlayerPositionZ" + slot);

        player.transform.position = playerPositionData;
        //check voor 1 of 0 1 is true 0 is false
        boostCheckInt = PlayerPrefs.GetInt("BoostCheck" + slot);

        if(boostCheckInt == 1)
        {
            playerMec.checkIfBoosting = true;
        }
        else
        {
            playerMec.checkIfBoosting = false;
        }

        playerMec.jumpBoost = PlayerPrefs.GetFloat("JumpBoostCheck" + slot);
    }


    public void Slot1()
    {
        slot = 1;
        PlayerPrefs.SetInt("SlotNumber", slot);
    }

    public void Slot2()
    {
        slot = 2;
        PlayerPrefs.SetInt("SlotNumber", slot);
    }
    public void Slot3()
    {
        slot = 3;
        PlayerPrefs.SetInt("SlotNumber", slot);
    }
}
