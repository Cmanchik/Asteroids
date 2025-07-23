using UnityEngine;
using UnityEngine.InputSystem;

namespace SpaceFighter.Movement
{
    public class MovementScript : MonoBehaviour
    {
        [SerializeField]
        private float movementSpeed;

        [SerializeField]
        private float rotationSpeed;

        [SerializeField] 
        private float rotationLimit;
        private Vector3 _rotationLimitVector;


        [SerializeField]
        private Rigidbody rb;
        
        private Vector3 _movementDirection;
        private Vector2 _inputDirection;

        private InputAction _movementAction;

        private void Start()
        {
            _movementAction = InputSystem.actions.FindAction("Move");
            _rotationLimitVector = new Vector3(0, 0, rotationLimit);
        }

        private void Update()
        {
            _inputDirection = _movementAction.ReadValue<Vector2>();
            _movementDirection = new Vector3(_inputDirection.x, 0, _inputDirection.y);
        }

        private void FixedUpdate()
        {
            rb.linearVelocity = _movementDirection * movementSpeed;
            Tilt();
        }

        private void Tilt()
        {
            //Debug.Log(_rotationLimitVector);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-_inputDirection.x * _rotationLimitVector), rotationSpeed);
        }
    }
}
