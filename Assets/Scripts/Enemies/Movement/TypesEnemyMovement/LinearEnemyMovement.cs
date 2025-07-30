using UnityEngine;

namespace Assets.Scripts.Enemies.Movement.TypesEnemyMovement
{
    public class LinearEnemyMovement : MovementEnemyAbstract
    {
        [SerializeField]
        private Vector3 _movementDirection;

        [SerializeField]
        private float movementSpeed;

        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        protected override void Move()
        {
            rb.linearVelocity = _movementDirection * movementSpeed;
        }
    }
}
