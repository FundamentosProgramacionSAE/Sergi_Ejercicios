using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionController : MonoBehaviour
{

    public GameObject Cube;

    public UnityAction TestEventAction;
    public  static UnityAction TestEventAction2;

    void Awake()
    {
        TestEventAction += ShowAction;
        TestEventAction += SetBigPrimitive;
        TestEventAction2 += ActivatePrimitive;
    }  

    public void ShowAction()
    {
        print("Niklas no sabe programar");
    }

    public void SetBigPrimitive()
    {
        Cube.transform.localScale = new Vector3(2, 3, 4);
    }

    public void ActivatePrimitive()
    {
        Cube.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            TestEventAction.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            TestEventAction2.Invoke();
        }
    }
}
