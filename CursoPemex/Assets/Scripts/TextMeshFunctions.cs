using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class TextMeshFunctions : MonoBehaviour
{
    public int selecter;
    public int number = 0;

    private string baseMessage = "Este es el mensaje base que programamos";
    public string message;

    public TextMeshProUGUI textNumber;
    public TextMeshProUGUI textEditable;

    public Canvas interactCanvas;

    public PlayerInput playerInput;
    public InputAction interact;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interact = playerInput.actions.FindAction("Player/Interact");
    }

    // Update is called once per frame
    void Update()
    {
        if (interact.ReadValue<float>() > 0)
        {
            switch (selecter)
            {
                case 0:
                    number = int.Parse(textNumber.text);
                    number += 1;
                    textNumber.text = number.ToString();
                    break;
                case 1:
                    number = int.Parse(textNumber.text);
                    number -= 1;
                    textNumber.text = number.ToString();
                    break;
                case 2:
                    number = 0;
                    textNumber.text = number.ToString(); 
                    break;
                case 3:
                    textEditable.text = baseMessage;
                    break;
                case 4:
                    textEditable.text = message;
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
