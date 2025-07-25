using UnityEngine;

namespace Assets.Scripts.SpaceFighter.Weapon
{
    public abstract class WeaponAbstract : MonoBehaviour
    {
        [SerializeField] protected GameObject bullet;

        [SerializeField] protected float interval;

        [SerializeField] protected Transform rightWeapon;
        [SerializeField] protected Transform leftWeapon;

        public void StartFire()
        {
            InvokeRepeating(nameof(Fire), 0, interval);
        }

        public void StopFire()
        {
            CancelInvoke(nameof(Fire));
        }

        protected abstract void Fire();
    }
}


