using Assets.Scripts.General.Randomizer;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner.TypesSpawners
{
    public class RandomEnemiesRandomLineSpawner : ReapetingSpawnerAbstract
    {
        [SerializeField]
        private EDirectionSpawn directionSpawn;

        [SerializeField]
        private ObjectWithWeight[] enemies;

        private MeshRenderer meshRenderer;
        private Transform spawnerTransform;

        private float spawnSpaceDistance;
        

        private void Awake()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            spawnerTransform = transform;
        }

        private void Start()
        {
            spawnSpaceDistance = GetSpawnSpaceDistance();
            StartSpawn();
        }

        private float GetSpawnSpaceDistance() => directionSpawn switch
        {
            EDirectionSpawn.X => meshRenderer.bounds.size.x,
            EDirectionSpawn.Y => meshRenderer.bounds.size.y,
            EDirectionSpawn.Z => meshRenderer.bounds.size.z,
            _ => spawnSpaceDistance
        };

        private Vector3 GetRandomVector3Position() => directionSpawn switch
        {
            EDirectionSpawn.X => new Vector3(Random.Range(-spawnSpaceDistance / 2, spawnSpaceDistance / 2), spawnerTransform.position.y, spawnerTransform.position.z),
            EDirectionSpawn.Y => new Vector3(spawnerTransform.position.x, Random.Range(-spawnSpaceDistance / 2, spawnSpaceDistance / 2), spawnerTransform.position.z),
            EDirectionSpawn.Z => new Vector3(spawnerTransform.position.x, spawnerTransform.position.y, Random.Range(-spawnSpaceDistance / 2, spawnSpaceDistance / 2)),
            _ => Vector3.zero
        };

        protected override void Spawn()
        {
            Instantiate(RandomizerWithWeight.GetRandomObject(enemies).Object, GetRandomVector3Position(), Quaternion.identity);
        }
    }
}