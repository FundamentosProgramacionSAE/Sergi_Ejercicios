using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Block
{
    public int VidaRock = 5;
    
    
    public void Picar()
    {
        VidaRock = VidaRock - 1;
    }

    public override void Destroy()
    {
        base.Destroy();               
    }
}
