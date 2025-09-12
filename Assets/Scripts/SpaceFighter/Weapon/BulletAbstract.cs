using Assets.Scripts.General.Character;
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

        protected virtual void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent<HealthPoint>(out var hpEnemy)) hpEnemy.OnTakeDamage(damage);
        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}