using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace Sirenix.Serialization
{
	public class UnityEventFormatter<T> : ReflectionFormatter<T> where T : UnityEventBase, new()
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override T GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnityEventFormatter()
		{
			throw null;
		}
	}
}
