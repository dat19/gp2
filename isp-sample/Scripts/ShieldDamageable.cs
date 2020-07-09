using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolidSample
{
	public class ShieldDamageable : MonoBehaviour, IPlayerDamageable
	{
		[Tooltip("耐久力"), SerializeField]
		int life = 10;
		[Tooltip("爆発エフェクト"), SerializeField]
		GameObject explosionPrefab = null;

		public void Damage(int power)
		{
			life -= power;

			if (life <= 0)
			{
				Instantiate(explosionPrefab, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
		}
	}
}