using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrutinasScripts : MonoBehaviour
{
    public GameObject sphere;
    public float repeatSeconds;
    public Transform originSeconds;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TiempoDeEsperaPorSegundos());
    }

    IEnumerator TiempoDeEsperaPorSegundos()
    {
        yield return new WaitForSeconds(repeatSeconds);
        Instantiate(sphere, originSeconds.position, originSeconds.rotation);
        StartCoroutine(TiempoDeEsperaPorSegundos());
    }
    
   
    
}
