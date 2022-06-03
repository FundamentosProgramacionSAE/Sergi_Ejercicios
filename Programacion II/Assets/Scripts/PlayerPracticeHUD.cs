using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPracticeHUD : MonoBehaviour
{
    public HUDController HUDControlador;
    void Start()
    {
        SceneManager.LoadScene(0);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HUDControlador.CambiarBarraVida(0.7f);
        }  
    }
}
