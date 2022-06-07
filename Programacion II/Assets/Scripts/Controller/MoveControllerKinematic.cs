using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControllerKinematic : MonoBehaviour
{
    public float Velocity = 10f;

    private Rigidbody _rigidbody;
    private Vector3 _movementDirection = Vector3.zero;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.MovePosition(_rigidbody.position + _movementDirection.normalized * Velocity * Time.fixedDeltaTime); 
    }

    void Update()
    {
        _movementDirection.x = Input.GetAxis("Horizontal");
        _movementDirection.z = Input.GetAxis("Vertical");

    }


}
