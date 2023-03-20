using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void DoorLower(GameObject door, Vector3 lowering, float loweringLimit)
    {
        if (door.transform.position.y >= loweringLimit)
        {
            door.transform.position -= lowering * Time.deltaTime;
        }
    }

    public void DoorRaise(GameObject door, Vector3 lowering, float loweringLimit)
    {
        if (door.transform.position.y <= loweringLimit)
        {
            door.transform.position -= lowering * Time.deltaTime;
        }
    }
}
