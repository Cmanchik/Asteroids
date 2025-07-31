using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    public abstract class ReapetingSpawnerAbstract : SpawnerAbstract
    {
        [SerializeField]
        protected float repeatRate;

        public void StartSpawn()
        {
            InvokeRepeating(nameof(Spawn), 0, repeatRate);
        }

        public void StopSpawn()
        {
            CancelInvoke(nameof(Spawn));
        }
    }
}