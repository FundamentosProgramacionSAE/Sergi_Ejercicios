using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    
   

    public virtual void Destroy()
    {
        Destroy(this.gameObject);       
    }

    
   
}
