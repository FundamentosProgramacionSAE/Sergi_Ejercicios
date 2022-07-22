using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilPrefab : MonoBehaviour
{

    public Rigidbody RB;
    public float Speed;
    private Transform cam;

    void Start()
    {
        cam = Camera.main.gameObject.transform; 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("Enemy"));
        }
    }

    void Update()
    {
        RB.AddForce(cam.forward.normalized * Speed * Time.deltaTime, ForceMode.Impulse);
    }
}
