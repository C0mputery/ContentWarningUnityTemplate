using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PCurve
{
	public abstract class PCurveBase : MonoBehaviour
	{
		public abstract void Play();

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected PCurveBase()
		{
			throw null;
		}
	}
}
