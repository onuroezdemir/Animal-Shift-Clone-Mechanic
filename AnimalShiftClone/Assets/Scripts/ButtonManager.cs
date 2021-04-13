using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnBluePressed.AddListener(BlueButton);
        EventManager.OnGreenPressed.AddListener(GreenButton);
    }

    private void OnDisable()
    {
        EventManager.OnBluePressed.RemoveListener(BlueButton);
        EventManager.OnGreenPressed.RemoveListener(GreenButton);
    }

    public void BlueButton()
    {
        EventManager.OnGravityBlueChanged?.Invoke();
    }

    public void GreenButton()
    {
        EventManager.OnGravityGreenChanged?.Invoke();
    }
}
