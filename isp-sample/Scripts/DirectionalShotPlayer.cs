using UnityEngine;

namespace SolidSample
{
	public class DirectionalShotPlayer : PlayerDefault
	{
		protected override void SpecialShot()
		{
			float rotz = Vector3.SignedAngle(
				Vector3.right,
				rb.velocity.normalized,
				Vector3.forward);

			Instantiate(shotPrefab, transform.position,
				Quaternion.AngleAxis(
					rotz, Vector3.forward));
		}
	}
}