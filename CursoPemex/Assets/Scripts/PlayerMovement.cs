using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public PlayerInput playerInput;
    public InputAction move;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        move = playerInput.actions.FindAction("Player/Move");
    }

    // Update is called once per frame
    void Update()
    {
        if (move != null)
        {
            Vector2 direction = move.ReadValue<Vector2>();
            Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
            transform.position += moveDirection * (Time.deltaTime * speed);

        }

    }
}
