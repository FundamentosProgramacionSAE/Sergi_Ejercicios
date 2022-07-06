using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRandomArrowBar : MonoBehaviour
{

    public RectTransform Padre;
    public RectTransform ZonaVerde;
    public RectTransform Flecha;
    private float Limites;

    private float newX;

    public float SpeedMoveArrow = 1f;

    void Start()
    {
        Limites = Padre.sizeDelta.x / 2f;

        
    }

  
    void Update()
    {
        

        MoverFlecha();
        PulsarTecla();

    }
    public void MoverFlecha()
    {
        newX = Limites * Mathf.Sin(Time.time * SpeedMoveArrow);

        Flecha.localPosition = new Vector3(newX, Flecha.localPosition.y, Flecha.localPosition.z);
    }

    public void Randomizar()
    {
        SpeedMoveArrow = Random.Range(1f, 5.0f);

        float nuevaX = Random.Range(10f, 300f);
        ZonaVerde.sizeDelta = new Vector2(nuevaX, ZonaVerde.sizeDelta.y);
    }

    public void PulsarTecla()
    {
        float LimitesVerdes = ZonaVerde.sizeDelta.x / 2f;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (-LimitesVerdes < newX && newX < LimitesVerdes)
            {
                print("Bingo");
            }
            else
            {
                print("Loser");
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Randomizar();
        }
    }
}
