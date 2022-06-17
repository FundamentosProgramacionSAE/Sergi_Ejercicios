using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PuzzleOntrigger : MonoBehaviour
{
    //[SerializeField]
    public UnityEvent OnEnterCollider;
    public UnityEvent OnExitCollider;

    private void OnTriggerEnter(Collider other)
    {
        OnEnterCollider.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        OnExitCollider.Invoke();
    }
}
