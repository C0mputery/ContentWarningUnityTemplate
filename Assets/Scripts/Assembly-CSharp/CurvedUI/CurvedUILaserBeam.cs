using System.Runtime.CompilerServices;
using UnityEngine;

namespace CurvedUI
{
	public class CurvedUILaserBeam : MonoBehaviour
	{
		[SerializeField]
		private Transform LaserBeamTransform;

		[SerializeField]
		private Transform LaserBeamDot;

		[SerializeField]
		private bool hideWhenNotAimingAtCanvas;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUILaserBeam()
		{

		}
	}
}
