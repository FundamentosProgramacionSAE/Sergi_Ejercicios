using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand : Block
{
    public int VidaSand = 3;

    public void Start()
    {
        ActionController.TestEventAction2 += Picar;        
    }
    public void Picar()
    {
        VidaSand = VidaSand - 1;
    }

    public override void Destroy()
    {
        base.Destroy();
    }
}
