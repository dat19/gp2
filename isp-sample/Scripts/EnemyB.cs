using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolidSample
{
    public class EnemyB : MonoBehaviour
    {
        [Tooltip("最高速度"), SerializeField]
        float maxSpeed = 4;
        [Tooltip("1周の秒数"), SerializeField]
        float rollingTime = 2;

        Rigidbody rb = null;
        float theta = 0;

        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            theta = 0;
        }

        void FixedUpdate()
        {
            theta += (Mathf.PI * 2f / rollingTime) * Time.fixedDeltaTime;
            rb.velocity = Vector3.up * Mathf.Cos(theta) * maxSpeed;
        }
    }
}