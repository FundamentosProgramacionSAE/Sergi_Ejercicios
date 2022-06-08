using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public GameObject Player;
    public float Fuerza;
    public GameObject LoserScreen;
    public GameObject WinnerScreen;
    public GameObject WinGame;
    public List <GameObject> Spheres;
    public bool CanYouWin;

    private Rigidbody _rigidbody;
    private Vector3 _movementDirection;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Move()
    {
        
        _rigidbody.MovePosition(transform.position+transform.forward * Fuerza * Time.deltaTime);

    }
    void FixedUpdate()
    {
        Move();
    }

    public void ClickAndRotatePositive()
    {
        Player.transform.Rotate(0, 90f, 0);
    }
    public void ClickandRotateNegative()
    {
        Player.transform.Rotate(0, -90f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            LoserScreen.SetActive(true);  
        }
        if (other.CompareTag("Pelota"))
        {
            Spheres.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Win"))
        {
            WinnerScreen.SetActive(true);
        }
    }
    public bool ArrayEmpty()
    {
        if (Spheres == null || Spheres.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    private void Update()
    {
        CanYouWin = ArrayEmpty();
        if (CanYouWin == true)
        {
            WinGame.SetActive(true);
        }
    }


}
