using System;
using UnityEngine;

public class UnityFuntions : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Esta es la primera funcion que se va a correr en el programa");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Esta es la segunda funcion que se corre en el programa");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Esta funcion se llama 1 ves cada frame");
    }
}
