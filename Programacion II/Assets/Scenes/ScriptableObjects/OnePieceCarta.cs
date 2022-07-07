using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnePieceCarta : MonoBehaviour
{

    public Carta Carta;
    public Carta Carta2;

    public Image ImageCriature;
    public Text NameText;
    public Text DescriptionText;
    public Text CaractText;
    public Text PowerText;
    public Image RareCriature;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            ImageCriature.sprite = Carta.ImageCriature;
            NameText.text = Carta.NameText;
            DescriptionText.text = Carta.DescriptionText;
            CaractText.text = Carta.CaractText;
            PowerText.text = Carta.PowerText;
            RareCriature.color = Carta.RareCriature;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ImageCriature.sprite = Carta2.ImageCriature;
            NameText.text = Carta2.NameText;
            DescriptionText.text = Carta2.DescriptionText;
            CaractText.text = Carta2.CaractText;
            PowerText.text = Carta2.PowerText;
            RareCriature.color = Carta2.RareCriature;
        }
    }
}
