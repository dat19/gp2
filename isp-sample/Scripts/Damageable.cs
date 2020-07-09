using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolidSample
{
    public class Damageable : MonoBehaviour
    {
        [Tooltip("爆発プレハブ"), SerializeField]
        GameObject explosionPrefab = null;

        /// <summary>
        /// ヒットポイント
        /// </summary>
        public int hp = 2;

        public virtual void Damage(int damage)
        {
            hp -= damage;
            if (hp <= 0)
            {
                Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}