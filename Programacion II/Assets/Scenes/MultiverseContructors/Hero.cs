using UnityEngine;
public class Hero : MonoBehaviour
{

    public string NombreHero;
    public int Edad;
    public static float NumPoderes;
    public float Poderes { get { return NumPoderes; } }
    
    public Hero()
    {

    }
    public Hero(string _nombreHero)
    {
        NombreHero = _nombreHero;
    }
    public Hero(string _nombreHero, int _edad, float _numPoderes)
    {
        NombreHero = _nombreHero;
        Edad = _edad;
        NumPoderes = _numPoderes;
    }

  


    
}
