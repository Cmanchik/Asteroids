using UnityEngine;

namespace Assets.Scripts.SpaceFighter.Weapon
{
    public abstract class BulletAbstract : MonoBehaviour
    {
        [SerializeField] protected int damage;
        [SerializeField] protected float speed;

        protected Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        protected abstract void Move();

        protected abstract void OnCollisionEnter(Collision collision);

        private void FixedUpdate()
        {
            Move();
        }
    }
}