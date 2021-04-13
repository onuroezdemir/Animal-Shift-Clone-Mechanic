using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    [Space]
    [SerializeField]
    private Vector3 GravityUp = new Vector3(0f, 5f, 0f);

    [Space]
    [SerializeField]
    private Vector3 GravityDown = new Vector3(0f,-10f,0f);

    private void OnEnable()
    {
        EventManager.OnGravityBlueChanged.AddListener(GravityEagle);
        EventManager.OnGravityGreenChanged.AddListener(GravityHorse);
    }

    private void OnDisable()
    {
        EventManager.OnGravityBlueChanged.RemoveListener(GravityEagle);
        EventManager.OnGravityGreenChanged.RemoveListener(GravityHorse);
    }

    public void GravityHorse()
    {
        Physics.gravity = GravityDown;
    }

    public void GravityEagle()
    {
        Physics.gravity = GravityUp;
    }
}
