using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationsCoins : MonoBehaviour
{
    public GameObject CoinPrefab;

    public float NumCopiesPrefab;

    public Vector3 PosInstanPrefab;

    public float DistanceCoins;

    public GameObject Carpeta;

    void Start()
    {
        
    }

    public void RandomCoin()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (Transform hijo in Carpeta.transform)
            {
                Destroy(hijo.gameObject);
            }
            NumCopiesPrefab = Random.Range(1f, 20f);
            DistanceCoins = Random.Range(1, 3);
            Vector3 newPos;
            for (int i = 0; i < NumCopiesPrefab; i++)
            {
                newPos = new Vector3(PosInstanPrefab.x + i * DistanceCoins, PosInstanPrefab.y, PosInstanPrefab.z);
                GameObject MonedaCreada = Instantiate(CoinPrefab, newPos, CoinPrefab.transform.rotation);
                MonedaCreada.transform.parent = Carpeta.transform;
            }
        }
    }

    
    void Update()
    {
        RandomCoin();
    }
}
