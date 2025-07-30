using UnityEngine;

namespace Assets.Scripts.Enemies.Movement
{
    public abstract class MovementEnemyAbstract : MonoBehaviour
    {
        private void FixedUpdate()
        {
            Move();
        }

        protected abstract void Move();
    }
}