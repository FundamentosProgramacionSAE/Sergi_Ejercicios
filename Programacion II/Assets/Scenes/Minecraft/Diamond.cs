using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : Block
{
    public int VidaDiamond = 7;
    public GameObject DiamondPure;


    public void Picar()
    {
        VidaDiamond = VidaDiamond - 1;
        if (VidaDiamond <= 0)
        {            
            this.Destroy();
        }
    }
    public override void Destroy()
    {              
        base.Destroy();  
        if(DiamondPure != null)
        {
            DiamondPure.SetActive(true);
        }
        

    }
    private void Update()
    {
        print(VidaDiamond + gameObject.name);
    }
}
