using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner.TypesSpawners
{
    public class RandomEnemiesRandomLineSpawner : ReapetingSpawnerAbstract
    {
        [SerializeField]
        private DirectionSpawn directionSpawn;

        [SerializeField]
        private GameObject[] enemies;

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
            DirectionSpawn.X => meshRenderer.bounds.size.x,
            DirectionSpawn.Y => meshRenderer.bounds.size.y,
            DirectionSpawn.Z => meshRenderer.bounds.size.z,
            _ => spawnSpaceDistance
        };

        private Vector3 GetRandomVector3Position() => directionSpawn switch
        {
            DirectionSpawn.X => new Vector3(Random.Range(-spawnSpaceDistance / 2, spawnSpaceDistance / 2), spawnerTransform.position.y, spawnerTransform.position.z),
            DirectionSpawn.Y => new Vector3(spawnerTransform.position.x, Random.Range(-spawnSpaceDistance / 2, spawnSpaceDistance / 2), spawnerTransform.position.z),
            DirectionSpawn.Z => new Vector3(spawnerTransform.position.x, spawnerTransform.position.y, Random.Range(-spawnSpaceDistance / 2, spawnSpaceDistance / 2)),
            _ => Vector3.zero
        };

        protected override void Spawn()
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], GetRandomVector3Position(), Quaternion.identity);
        }
    }
}