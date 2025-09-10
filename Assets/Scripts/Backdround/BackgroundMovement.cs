using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Backdround
{
    public class BackgroundMovement : MonoBehaviour
    {
        [SerializeField]
        private float m_speed;

        [Space]

        [SerializeField]
        private Transform m_startPoint;

        [SerializeField]
        private Transform m_endPoint;

        [Space]

        [SerializeField]
        private Transform[] m_backgroundImages;

        private void FixedUpdate()
        {
            foreach (Transform transformImage in m_backgroundImages) 
            {
                if (transformImage.position == m_endPoint.position)
                {
                    transformImage.position = m_startPoint.position;
                }

                transformImage.position = Vector3.MoveTowards(transformImage.position, m_endPoint.position, m_speed);
            }
        }
    }
}