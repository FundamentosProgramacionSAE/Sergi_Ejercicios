using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChisteCorutinas : MonoBehaviour
{


    public Text TextChiste;
    private string Answer = "-¿Y por qué has dibujado un dedo en la primera página?";
    private string Answer2 = "-Es el índice.";
    void Start()
    {

    }

    public void ButtonJoke()
    {
        StartCoroutine(Chiste());
    }

    IEnumerator Chiste()
    {
        TextChiste.text = ("Acabo de escribir un libro. ");
        yield return new WaitForSeconds(1.5f);
        TextChiste.text = "";
        foreach (char c in Answer)
        {
            TextChiste.text += c;
            yield return new WaitForSeconds(0.07f);

        }
        yield return new WaitForSeconds(1.5f);
        TextChiste.text = "";
        foreach (char c in Answer2)
        {
            TextChiste.text += c;
            yield return new WaitForSeconds(0.07f);
        }
    }

    void Update()
    {

    }
}
