using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterController : MonoBehaviour
{
    
    public float Speed;
    public float Gravity;
    public float JumpHeight;
    public bool IsGrounded;
    private Vector3 _moveDirection = Vector3.zero;
    public Transform GroundDetection;
    public LayerMask GroundLayer;

    private CharacterController PlayerController;
    private Vector3 velocity;

    void Start()
    {
        PlayerController = GetComponent<CharacterController>();
    }
    
    void Update()
    {

        IsGrounded = Physics.CheckSphere(GroundDetection.position, 0.5f, GroundLayer);
        if (velocity.y < 0 && IsGrounded)
        {
            velocity.y = -2f;
        }
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xDirection + transform.forward * zDirection;

        PlayerController.Move(move * Time.deltaTime * Speed);

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
            print(velocity);

        }
        velocity.y += Gravity * Time.deltaTime;
        PlayerController.Move(_moveDirection * Time.deltaTime);
         
    }
}
