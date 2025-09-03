using UnityEngine;

public class DetenerCorrutinas : MonoBehaviour
{
    public CorrutinasScripts corrutinasScripts;
    private void OnTriggerEnter(Collider other)
    {
        corrutinasScripts.StopAllCoroutines();
    }
}
