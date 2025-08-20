using Assets.Scripts.General.Character;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public abstract class EnemyAbstract : MonoBehaviour
    {
        [SerializeField]
        protected int collisionDamage;

        public virtual void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.TryGetComponent<HealthPoint>(out var hpEnemy)) hpEnemy.TakeDamage(collisionDamage);
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) Destroy(gameObject);
        }
    }
}