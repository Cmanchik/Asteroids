using System.Collections;
using UnityEngine;

namespace Assets.Scripts.SpaceFighter.Weapon.TypesWeapons
{
    public class StandartWeapon : WeaponAbstract
    {
        private void Start()
        {
            StartFire();
        }

        protected override void Fire()
        {
            Instantiate(bullet, rightWeapon.position, Quaternion.Euler(90, 0, 0));
            Instantiate(bullet, leftWeapon.position, Quaternion.Euler(90, 0, 0));
        }
    }
}