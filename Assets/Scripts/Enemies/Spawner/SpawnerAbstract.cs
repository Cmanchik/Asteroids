using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    public abstract class SpawnerAbstract : MonoBehaviour
    {
        protected abstract void Spawn();
    }
}