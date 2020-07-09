using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolidSample
{
	/// <summary>
	/// 敵方にアタッチすると、プレイヤー方の
	/// IPlayerDamabeableのダメージを呼び出す
	/// </summary>
	public class Attacker : MonoBehaviour
	{
		[Tooltip("攻撃力"), SerializeField]
		int power = 1;

		void OnTriggerEnter(Collider other)
		{
			IPlayerDamageable ipd = other.GetComponent<IPlayerDamageable>();
			if (ipd != null)
			{
				ipd.Damage(power);
			}
		}

		void OnTriggerStay(Collider other)
		{
			OnTriggerEnter(other);
		}
	}
}