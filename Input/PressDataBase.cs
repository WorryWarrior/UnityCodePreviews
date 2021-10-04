using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PressDataBase : ScriptableObject
{
    public abstract bool IsPressed();

    public abstract bool IsHeld();
}
