using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA2_Idle : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state

    Transform Player;
    Transform IA2;

    float DisDeteccion = 8f;
    
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        IA2 = animator.transform;

        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float DistanciaPlayerIA = Vector3.Distance(Player.position, IA2.position);

        if (DistanciaPlayerIA < DisDeteccion)
        {
            animator.SetTrigger("Alert");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    
}
