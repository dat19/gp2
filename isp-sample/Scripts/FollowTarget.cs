using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolidSample
{
	public class FollowTarget : MonoBehaviour
	{
		[Tooltip("目的オブジェクト"), SerializeField]
		Transform target = null;

		Rigidbody rb = null;

		void Awake()
		{
			rb = GetComponent<Rigidbody>();
		}

		void FixedUpdate()
		{
			Vector3 tg = target.position - transform.position;
			rb.velocity = tg / Time.fixedDeltaTime;
		}
	}
}