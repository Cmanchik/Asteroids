using System;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.General.Character
{
    public class HealthPoint : MonoBehaviour
    {
        [SerializeField]
        private int health;

        public int Health { get => health; set => health = value; }

        [SerializeField]
        private UnityEvent Killing;

        [SerializeField]
        private UnityEvent TakingDamage;
        

        private void Awake()
        {
            Killing.AddListener(OnKilling);
        }

        public void OnTakeDamage(int damage)
        {
            health -= damage;

            if (health <= 0) Killing?.Invoke();
            else TakingDamage?.Invoke();
        }

        public void OnTakeLethalDamage()
        {
            Killing?.Invoke();
        }

        private void OnKilling()
        {
            Destroy(gameObject);
        }

        public void SubscribeToKilling(UnityAction call)
        {
            Killing.AddListener(call);
        }
    }
}