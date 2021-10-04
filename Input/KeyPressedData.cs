using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Key Press Data", menuName = "CustomObjects/Key Press Data")]
public class KeyPressedData : PressDataBase
{
    [SerializeField] private KeyCode keyCode = KeyCode.None;

    public override bool IsPressed()
    {
        if (Time.timeScale > 0)
        {
            return Input.GetKeyDown(keyCode);
        }
        return false;
    }

    public override bool IsHeld()
    {
        if (Time.timeScale > 0)
        {
            return Input.GetKey(keyCode);
        }
        return false;
    }
}
