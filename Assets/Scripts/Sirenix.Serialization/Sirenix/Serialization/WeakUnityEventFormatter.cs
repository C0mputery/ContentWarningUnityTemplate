using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakUnityEventFormatter : WeakReflectionFormatter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakUnityEventFormatter(Type serializedType) : base(serializedType)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override object GetUninitializedObject()
		{
			throw null;
		}
	}
}
