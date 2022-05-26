using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public CharacterController CharacterController;
    public float SpeedWalk;
    public float SpeedRun;
    public Animator Animator;

    private float _velocity;

    void Start()
    {
        
    }

    
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xAxis, 0f, zAxis);

        _velocity = Input.GetKey(KeyCode.LeftShift) ? SpeedRun : SpeedWalk;

        CharacterController.Move(movement * _velocity * Time.deltaTime);

        Animator.SetFloat("Horizontal", xAxis);
        Animator.SetFloat("Vertical", zAxis);

        


    }
}
