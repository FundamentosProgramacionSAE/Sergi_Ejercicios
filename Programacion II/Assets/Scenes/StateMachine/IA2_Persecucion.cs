using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA2_Persecucion : StateMachineBehaviour
{

    Transform Player;
    Transform IA2;

    float _velToGo = 1f;
    float DisDeteccion = 6f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        IA2 = animator.transform;

        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        IA2.position = Vector3.MoveTowards(IA2.position, Player.position, _velToGo * Time.deltaTime);
        float DistanciaPlayerIA = Vector3.Distance(IA2.position, Player.position);

        if (DistanciaPlayerIA > DisDeteccion)
        {
            animator.SetTrigger("Huir");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

    
}
