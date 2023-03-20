using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : Button
{
    public GameObject doorThisButton;
    public GameObject doorNextButton;
    public GameObject doorNextBall;

    public Vector3 loweringAmount;
    public float loweringLimit;

    public Vector3 raisingAmount;
    public float raisingLimit;

    public void OnTriggerStay(Collider triggerObject)
    {
        if (triggerObject.tag == "Ball")
        {
            DoorLower(doorThisButton, loweringAmount, loweringLimit);
            DoorLower(doorNextButton, loweringAmount, loweringLimit);
            DoorRaise(doorNextBall, raisingAmount, raisingLimit);
        }
    }
}
