using UnityEngine;

namespace SolidSample
{
    public class PlayerDefault : MonoBehaviour
    {
        [Tooltip("移動速度"), SerializeField]
        protected float speed = 10f;
        [Tooltip("ショットプレハブ"), SerializeField]
        protected GameObject shotPrefab = null;

        /// <summary>
        /// 移動目的座標を設定します。
        /// </summary>
        public Vector3 targetPosition;

        protected Rigidbody rb = null;
        Camera gameCamera = null;

        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            targetPosition = transform.position;
            gameCamera = Camera.main;
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (Input.GetButton("Fire2"))
                {
                    SpecialShot();
                }
                else
                {
                    Shot();
                }
            }

            UpdateMove();
        }

        /// <summary>
        /// 右ボタンが押されていたら呼び出します。
        /// </summary>
        protected virtual void SpecialShot()
        {
            Shot();
        }

        /// <summary>
        /// ショット時に呼び出します。
        /// </summary>
        public void Shot()
        {
            Instantiate(shotPrefab, transform.position,
                Quaternion.identity);
        }

        protected void UpdateMove()
        {
            Vector3 mpos = Input.mousePosition;
            mpos.z = transform.position.z
                - gameCamera.transform.position.z;
            targetPosition = gameCamera.ScreenToWorldPoint(mpos);
        }

        private void FixedUpdate()
        {
            Vector3 dir = targetPosition - transform.position;
            dir.z = 0f;
            float speedStep = speed * Time.fixedDeltaTime;
            float step = Mathf.Min(dir.magnitude, speedStep);
            if (!Mathf.Approximately(step, 0f))
            {
                step /= Time.fixedDeltaTime;
            }
            rb.velocity = dir.normalized * step;
        }
    }
}