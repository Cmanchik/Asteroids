using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.TypesEnemies.Asteroid
{
    public class AsteroidEnemy : EnemyAbstract
    {
        public override void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}