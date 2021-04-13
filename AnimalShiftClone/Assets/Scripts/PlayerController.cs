using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody body;
    [Space]
    [SerializeField]
    private float speed;
    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    void Update()
    {
        body.transform.position += Vector3.forward * speed;
    }
}
