using Assets.Scripts.Enemies.Movement.TypesEnemyMovement;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.TypesEnemies.Asteroid
{
    public class SplittingAsteroid : EnemyAbstract
    {
        [Space]

        [SerializeField]
        private LinearEnemyMovement m_asteroidFragment;

        [SerializeField]
        private int m_maxCountFragments;

        [Space]

        [SerializeField]
        private bool m_isRandomCountFragments;

        private void Start()
        {
            m_healthPoint.SubscribeToKilling(Split);
        }

        private void Split()
        {
            int countFragments;

            if (m_isRandomCountFragments) countFragments = Random.Range(1, m_maxCountFragments);
            else countFragments = m_maxCountFragments;

            for (int i = 0; i < countFragments; i++)
            {
                Instantiate(m_asteroidFragment, transform.position, Quaternion.identity).RotateMovementDirection(Random.Range(0, 360));
            }

        }
    }
}