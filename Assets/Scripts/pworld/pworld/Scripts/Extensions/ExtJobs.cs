using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Jobs;

namespace pworld.Scripts.Extensions
{
	public static class ExtJobs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Rotate(this TransformAccess _me, Vector3 _eulers, [DefaultValue("Space.Self")] Space _relativeTo)
		{
			throw null;
		}
	}
}
