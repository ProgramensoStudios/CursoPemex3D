using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class CanvasInter : MonoBehaviour
{
    public int selecter;

    public Canvas interactCanvas;
    public Slider sliderGlobal;
    public Slider sliderLocal;
    
    public PlayerInput playerInput;
    public InputAction interact;

    private void Start()
    {
        interact = playerInput.actions.FindAction("Player/Interact");
    }

    void Update()
    {
        if (interact.ReadValue<float>() > 0)
        {
            switch (selecter)
            {
                case 0:
                    sliderGlobal.value += 0.001f;
                    break;
                case 1:
                    sliderGlobal.value -= 0.001f;
                    break;
                case 2:
                    sliderGlobal.value = 0.5f;
                    break;
                case 3:
                    sliderLocal.value += 0.001f;
                    break;
                case 4:
                    sliderLocal.value -= 0.001f;
                    break;
                case 5:
                    sliderLocal.value = 0.5f;
                    break;
                default:
                    Debug.Log("esta opcion no deberia existir que esta pasandooooooooooo");
                    break;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        interactCanvas.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        interactCanvas.enabled = false;
    }


}
