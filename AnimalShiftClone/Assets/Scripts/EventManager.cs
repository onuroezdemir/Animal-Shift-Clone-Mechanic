using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent OnGravityBlueChanged = new UnityEvent();
    public static UnityEvent OnGravityGreenChanged = new UnityEvent();

    public static UnityEvent OnBluePressed = new UnityEvent();
    public static UnityEvent OnGreenPressed = new UnityEvent();
}
