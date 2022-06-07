using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public CharacterController CharacterController;
    public float SpeedWalk;
    public float SpeedRun;
    public Animator Animator;
    public float JumpForce;
    public float Gravity;
    public bool Grounded;
    

    private float _velocity;
    

    void Start()
    {

    }
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xAxis, 0f, zAxis);

        /*if (Input.GetKey(KeyCode.LeftShift))
        {
            _velocity = SpeedRun;
        }
        else
        {
            _velocity = SpeedWalk;
        }*/

        CharacterController.Move(movement * _velocity * Time.deltaTime);

        /*if (_velocity == SpeedWalk)
        {
            Animator.SetFloat("Horizontal", xAxis, 0.1f, Time.deltaTime);
            Animator.SetFloat("Vertical", zAxis, 0.1f, Time.deltaTime);
        }
        else
        {
            Animator.SetFloat("Vertical", 2, 0.1f, Time.deltaTime);
        }*/
        Grounded = CharacterController.isGrounded;
        if (Grounded)
        {            
            movement *= _velocity;

            if (Input.GetButton("Jump"))
            {
                movement.y = JumpForce;
            }     
        }
        movement.y -= Gravity * Time.deltaTime;

        CharacterController.Move(movement * Time.deltaTime);
        Debug.Log(CharacterController.isGrounded);
    }
}