using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	internal class ArrayFormatterLocator : IFormatterLocator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayFormatterLocator()
		{

		}
	}
}
