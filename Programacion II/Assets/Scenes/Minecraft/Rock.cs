using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Block
{
    public int VidaRock = 5;
    private AudioSource AudioRock;
    private RectTransform _RT;

    private void Start()
    {
        AudioRock = GetComponent<AudioSource>();
        _RT = GetComponent<RectTransform>();
    }
    public void Picar()
    {       
       AudioRock.Play();
       VidaRock = VidaRock - 1;

       if (VidaRock <= 0)
       {
            this.Destroy();
       }
       _RT.Rotate(0, 0, -180f);               
    }

    public override void Destroy()
    {
        base.Destroy();               
    }
}
