using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	internal class TypeFormatterLocator : IFormatterLocator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetFormatter(Type type, FormatterLocationStep step, ISerializationPolicy policy, bool allowWeakFallbackFormatters, out IFormatter formatter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeFormatterLocator()
		{

		}
	}
}
