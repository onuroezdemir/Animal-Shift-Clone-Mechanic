using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void TurnOffGravity()
    {
        EventManager.OnBluePressed?.Invoke();
    }

    public void TurnOnGravity()
    {
        EventManager.OnGreenPressed?.Invoke();
    }
}
