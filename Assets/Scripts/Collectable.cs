using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioClip coinSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D collission)
    {
        if (collission.gameObject.CompareTag("Player"))

        {
            collission.gameObject.GetComponent<AudioSource>().PlayOneShot(coinSound);

            Destroy(gameObject);

        }

    }
}

