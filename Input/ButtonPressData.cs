using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Button Press Data", menuName = "CustomObjects/Button Press Data")]
public class ButtonPressData : PressDataBase
{
    [SerializeField] private int buttonIndex = 0;

    public override bool IsPressed()
    {
        if (Time.timeScale > 0)
        {
            return Input.GetMouseButtonDown(buttonIndex);
        }
        return false;
    }

    public override bool IsHeld()
    {
        if (Time.timeScale > 0)
        {
            return Input.GetMouseButton(buttonIndex);
        }
        return false;
    }
}
