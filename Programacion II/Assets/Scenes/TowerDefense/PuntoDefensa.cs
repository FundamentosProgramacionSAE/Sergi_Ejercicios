using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoDefensa : MonoBehaviour
{
    public static float flechasPorSegundo = 2f;
    public static int numSoldadosPorSpawn;
    public static int vidaTorreta;
    public static float rangeTorreta;
    public float Count;
    public NivelTorreta NivelTorreta;


    void Start()
    {
        
        print("La Torreta esta al nivel" + NivelTorreta.Nivel);
    }

    public static void Attack()
    {
        
        print("Estoy atacando");
    }

    
    void Update()
    {
        Count = Count + Time.deltaTime;
        if (Count >= flechasPorSegundo)
        {
            Attack();
            Count = 0f;
        }
    }
}
