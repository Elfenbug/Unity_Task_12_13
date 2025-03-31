using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] private int _moveForce = 10;
    [SerializeField] private int _jumpForce = 5;

    private Rigidbody _rigidbody;
    private InputHandler _inputHandler;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _inputHandler = GetComponent<InputHandler>();
    }

    private void FixedUpdate()
    {
        if (_inputHandler.MoveDirection != Vector3.zero)
        {
            Vector3 force = _inputHandler.MoveDirection * _moveForce;
            _rigidbody.AddForce(force, ForceMode.Force);
        }

        if (_inputHandler.IsJumpRequested)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _inputHandler.ResetJump();
        }
    }
}
