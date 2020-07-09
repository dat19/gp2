using UnityEngine;

namespace SolidSample
{
    public class Shot : MonoBehaviour
    {
        [Tooltip("ショット速度"), SerializeField]
        float speed = 15f;
        [Tooltip("攻撃力"), SerializeField]
        int power = 1;

        const float LifeTime = 3;

        private void Awake()
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = transform.right * speed;
            Destroy(gameObject, LifeTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            Damageable en = other.GetComponent<Damageable>();
            if (en != null)
            {
                en.Damage(power);
                Destroy(gameObject);
            }
        }
    }
}