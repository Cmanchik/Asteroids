using Assets.Scripts.General.Character;
using UnityEngine;

namespace Assets.Scripts.Enemies.TypesEnemies.Asteroid
{
    public class AsteroidEnemy : EnemyAbstract
    {
        public override void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.GetComponent<HealthPoint>()?.TakeDamage(collisionDamage);
        }
    }
}