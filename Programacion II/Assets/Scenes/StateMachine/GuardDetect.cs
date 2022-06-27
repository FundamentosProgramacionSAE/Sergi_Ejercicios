using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardDetect : MonoBehaviour
{

    public Animator GuardAnimatorController;
    

    private void OnTriggerEnter(Collider other)
    {
        GuardAnimatorController.SetTrigger("TriggerAlert");
        print("Detectado Player");
    }

    private void OnTriggerExit(Collider other)
    {
        GuardAnimatorController.SetTrigger("TriggerAlert");
        print("Lost Player");
    }
    
}
