using Assets.Scripts.General.Character;
using UnityEngine;
 
namespace Assets.Scripts.SpaceFighter.Weapon.TypesBullets
{
    public class StandartBullet : BulletAbstract
    {
        protected override void Move()
        {
            rb.linearVelocity = Vector3.forward * speed;
        }

        protected override void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.GetComponent<HealthPoint>()?.TakeDamage(damage);
        }
    }
}