using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun.UtilityScripts
{
	public class OnEscapeQuit : MonoBehaviour
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Conditional("UNITY_ANDROID")]
		[Conditional("UNITY_IOS")]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnEscapeQuit()
		{
			throw null;
		}
	}
}
