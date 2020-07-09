using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SolidSample
{
	/// <summary>
	/// 敵方(Attackerクラス)から、ダメージを受けるインターフェース
	/// </summary>
	public interface IPlayerDamageable
	{
		void Damage(int power);
	}
}