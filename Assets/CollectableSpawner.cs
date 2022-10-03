using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject PikachuPrefab; 
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (Random.Range(0,2) == 1)
            Instantiate(PikachuPrefab, spawnPoints [i].transform.position, Quaternion.identity);
        }
    }

}
