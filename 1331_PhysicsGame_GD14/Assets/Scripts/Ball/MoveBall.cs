using UnityEngine;
using UnityEngine.InputSystem;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _force;
    [SerializeField] private Rigidbody _rb;

    private Vector2 _input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        _rb.AddForce(_force);
    }

    public void Move(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();
        _force.x = _speed * _input.x;
        if (context.canceled) _force = Vector3.zero;
    }
}
