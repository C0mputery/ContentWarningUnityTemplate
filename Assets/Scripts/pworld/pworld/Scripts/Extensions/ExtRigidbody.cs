using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.Extensions
{
	public static class ExtRigidbody
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddForceAtPosition(this Rigidbody me, Vector3 force, Vector3 position, ForceMode fMode, float lineLenMul)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void AddForce(this Rigidbody me, Vector3 force, ForceMode fMode, float lineLenMul)
		{
			throw null;
		}
	}
}
