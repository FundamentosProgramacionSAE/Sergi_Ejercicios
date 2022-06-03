using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDController : MonoBehaviour
{

    //public Image BarraVida;
    //public SceneManager ControladorDeEscenas;
    void Start()
    {
        //CambiarBarraVida(0.1f);
        SceneManager.LoadScene(0);
    }

    public void CambiarBarraVida(float ValueVida)
    {
        //BarraVida.fillAmount = ValueVida;
        
    }

    
    void Update()
    {
        
    }
}
