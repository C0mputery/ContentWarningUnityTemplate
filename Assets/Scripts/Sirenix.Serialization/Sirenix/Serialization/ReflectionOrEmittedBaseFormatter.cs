using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class ReflectionOrEmittedBaseFormatter<T> : ReflectionFormatter<T>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ReflectionOrEmittedBaseFormatter()
		{
			throw null;
		}
	}
}
