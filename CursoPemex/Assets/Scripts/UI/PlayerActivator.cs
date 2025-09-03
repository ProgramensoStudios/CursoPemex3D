using Unity.VisualScripting;
using UnityEngine;

public class PlayerActivator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CanvasInter canvasInter = other.GetComponent<CanvasInter>();
        canvasInter.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasInter canvasInter = other.GetComponent<CanvasInter>();
        canvasInter.enabled = false;
    }
}
