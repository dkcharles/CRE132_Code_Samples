using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerAttributes.AddHealth(10.0f);
            Destroy(gameObject, 0.1f);
        }
    }




}
