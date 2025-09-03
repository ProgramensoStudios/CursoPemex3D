using UnityEngine;

public class PlayerTMPActivator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        TextMeshFunctions canvasInter = other.GetComponent<TextMeshFunctions>();
        canvasInter.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        TextMeshFunctions canvasInter = other.GetComponent<TextMeshFunctions>();
        canvasInter.enabled = false;
    }
}
