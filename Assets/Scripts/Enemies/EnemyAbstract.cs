using Assets.Scripts.General.Character;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public abstract class EnemyAbstract : MonoBehaviour
    {
        [SerializeField]
        protected int collisionDamage;

        protected HealthPoint m_healthPoint;

        protected virtual void Start()
        {
            m_healthPoint = GetComponent<HealthPoint>();
        }

        public virtual void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent<HealthPoint>(out var hpEnemy)) hpEnemy.OnTakeDamage(collisionDamage);
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) m_healthPoint.OnTakeLethalDamage();
        }
    }
}