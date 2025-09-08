using UnityEngine;
using UnityEngine.InputSystem;

public class AudioInteract : MonoBehaviour
{
    public int selecter;

    public PlayerInput playerInput;
    public InputAction interact;

    public AudioManager audioManager;

    public AudioClip clip;

    public bool canInteract = false;
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        interact = playerInput.actions.FindAction("Player/Interact");
    }

    // Update is called once per frame
    void Update()
    {
        if (interact.ReadValue<float>() > 0 && canInteract)
        {
            switch (selecter)
            {
                case 0:
                    audioManager.AddSound();
                    break;
                case 1:
                    audioManager.RestSound();
                    break;
                case 2:
                    audioManager.PlaySound(clip);
                    break;
            }
        }
    }
}
