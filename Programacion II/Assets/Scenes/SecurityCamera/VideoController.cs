using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{

    public VideoPlayer VideoPlayer;
    public GameObject Plane;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VideoPlayer.Play();
            Plane.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VideoPlayer.Stop();            
            Plane.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
