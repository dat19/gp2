using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolidSample
{
	public class DefenceDamageable : Damageable
	{
		[Tooltip("これ以上のパワーじゃないとノーダメ"), SerializeField]
		int defence = 2;

		public override void Damage(int damage)
		{
			if (damage >= defence)
			{
				base.Damage(damage);
			}
		}
	}
}