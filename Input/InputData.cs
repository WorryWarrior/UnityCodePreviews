using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Input Data", menuName = "CustomObjects/Input Data")]
public class InputData : ScriptableObject
{
    [SerializeField] private InputMode inputMode = null;
    public InputMode InputMode => inputMode;

    public string VerticalAxisName
    {
        get
        {
            if (inputMode.MouseDriven)
            {
                return "Asteroids_Mouse_Vertical";
            }
            return "Vertical";
        }
    }

    public bool ShootCommand()
    {
        for (int i = 0; i < inputMode.shootCondtols.Count; i++)
        {
            if (inputMode.shootCondtols[i].IsPressed())
            {
                return true;
            }
        }
        return false;
    }

    public bool MoveCommand()
    {
        for (int i = 0; i < inputMode.movementControls.Count; i++)
        {
            if (inputMode.movementControls[i].IsHeld())
            {
                return true;
            }
        }
        return false;
    }

    public void ChangeInputMode(InputMode _inputMode)
    {
        inputMode = _inputMode;
    }
}
