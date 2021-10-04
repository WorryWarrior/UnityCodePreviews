using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Input Mode", menuName = "CustomObjects/Input Mode")]
public class InputMode : ScriptableObject
{
    public List<PressDataBase> movementControls = null;
    public List<PressDataBase> shootCondtols = null;
    [SerializeField] private bool mouseDriven = false;

    public bool MouseDriven => mouseDriven;
}
