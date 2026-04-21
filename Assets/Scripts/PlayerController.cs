using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5;
    private Rigidbody rb;
    private Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Start");
    }

    private void OnMove(InputValue moveValue)
    {
        Vector2 input = moveValue.Get<Vector2>();
        movement = input;
        Debug.Log(input);
    }

    private void FixedUpdate()
    {
        Vector3 move = new Vector3(movement.x, 0f, movement.y);
        rb.AddForce(move * Speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}