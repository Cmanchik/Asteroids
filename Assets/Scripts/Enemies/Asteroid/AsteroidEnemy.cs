using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Asteroid
{
    public class AsteroidEnemy : EnemyAbstract
    {
        public override void OnCollisionEnter(Collision collision)
        {
            Destroy(gameObject);
        }
    }
}