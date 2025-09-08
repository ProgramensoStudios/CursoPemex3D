using UnityEngine;

public class PilarSound : MonoBehaviour
{
    public Canvas canvasIntereact;
    public int action;
    private AudioInteract audioInteract;

    private void OnTriggerEnter(Collider other)
    {
        canvasIntereact.enabled = true;
        audioInteract = other.gameObject.GetComponent<AudioInteract>();
        audioInteract.canInteract = true;
        audioInteract.selecter = action;
        
    }

    private void OnTriggerExit(Collider other)
    {
        audioInteract.canInteract = false;
        canvasIntereact.enabled = false;
    }

}
