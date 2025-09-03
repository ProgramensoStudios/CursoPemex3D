using System;
using UnityEngine;

public class CollidersScripts : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Esto es una colision que no permite el paso");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Esta colision si permite el paso");
    }
}
