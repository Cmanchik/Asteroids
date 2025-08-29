using System.Collections;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public abstract class WindowAbstract : MonoBehaviour
    {
        private GameObject window;

        private void Awake()
        {
            window = gameObject;
        }

        public void Open()
        {
            window.SetActive(true);
        }

        public void Close()
        {
            window.SetActive(false);
        }
    }
}