using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public abstract class EnemyAbstract : MonoBehaviour
    {
        [SerializeField]
        protected int collisionDamage;

        public abstract void OnCollisionEnter(Collision collision);
    }
}