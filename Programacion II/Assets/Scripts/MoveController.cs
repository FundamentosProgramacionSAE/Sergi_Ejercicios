using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public float Fuerza = 10f;

    private Rigidbody _rigidbody;
    private Vector3 _movementDirection = Vector3.zero;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_movementDirection.normalized * Fuerza, ForceMode.Force); 
    }

    private void Move()
    {

    }
    void Update()
    {
        _movementDirection.x = Input.GetAxis("Horizontal");
        _movementDirection.z = Input.GetAxis("Vertical");

    }


}
