using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{

    [SerializeField] SpriteRenderer SpR;
    void Start()
    {
        SpR.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
    void Update()
    {
        
    }
}
