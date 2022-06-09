using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{

    public bool IsInRange;
    public KeyCode InteractKey;
    public UnityEvent InteractAction;
    public GameObject InteractText;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (IsInRange)
        {
            if (Input.GetKeyDown(InteractKey))
            {
                InteractAction.Invoke();
                print("Has interactuado con el cofre");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsInRange = true;
            print("Estamos en rango");
            InteractText.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsInRange = false;
            print("Estamos fuera de rango");
            InteractText.SetActive(false);
        }
    }
}
