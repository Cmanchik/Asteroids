using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DeathWall
{
    public class DeathWall : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Destroy(collision.gameObject);
        }
    }
}