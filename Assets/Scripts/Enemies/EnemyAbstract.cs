using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public abstract class EnemyAbstract : MonoBehaviour
    {
        [SerializeField]
        private int hp;


        public abstract void OnCollisionEnter(Collision collision);
    }
}