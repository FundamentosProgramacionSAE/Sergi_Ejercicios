using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Slider SoundSlider;
    public Text SoundTextValue;
  public void StartGame()
    {
        //Empezamos el juego al pulsar el boton de start.
        SceneManager.LoadScene("UIGame");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewSliderValue()
    {
        SoundTextValue.text = SoundSlider.value.ToString();
    }
}
