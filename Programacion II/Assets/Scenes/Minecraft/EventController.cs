using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyMultipleEvent : UnityEvent<int, float>
{

}
public class EventController : MonoBehaviour
{

    public UnityEvent TestUnityEvent;

    public MyMultipleEvent MyMultipleEvent;

    
    void Start()
    {
        TestUnityEvent.AddListener(ShowAction);
        MyMultipleEvent.AddListener(PrintSomething);
    }

    public void ShowAction()
    {
        print("Niklas no sabe programar");
    }

    public void PrintSomething(int numero, float restante)
    {
        print("Los numeros son : " + numero +  " y " + restante);
    }


    void Update()
    {
        if (Input.anyKeyDown)
        {
            TestUnityEvent.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            MyMultipleEvent.Invoke(7, 0.3f);
        }
    }
}
