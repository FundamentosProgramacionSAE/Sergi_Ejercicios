using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public GameObject Player;
    public float Fuerza;

    private Rigidbody _rigidbody;
    private Vector3 _movementDirection;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Move()
    {
        
        _rigidbody.MovePosition(transform.position+transform.forward * Fuerza * Time.deltaTime);

    }
    void FixedUpdate()
    {
        Move();
    }


}
