using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA2_Huir : StateMachineBehaviour
{
    Transform Player;
    Transform IA2;

    float _velHuir = 1f;
    float DisDeteccion = 10f;


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        IA2 = animator.transform;

        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector3 _vectorDirHuir = IA2.position - Player.position;//Huir
        //Vector3 _vectorDirHuir = Player.position - IA2.position;//Perseguir
        _vectorDirHuir = _vectorDirHuir.normalized;
        IA2.Translate(_vectorDirHuir * Time.deltaTime * _velHuir, Space.World);

        float DistanciaPlayerIA = Vector3.Distance(Player.position, IA2.position);
        if (DistanciaPlayerIA > DisDeteccion)
        {
            animator.SetTrigger("Idle");
        }

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
}
