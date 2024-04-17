using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public sealed class RegisterDictionaryKeyPathProviderAttribute : Attribute
	{
		public readonly Type ProviderType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegisterDictionaryKeyPathProviderAttribute(Type providerType)
		{
			throw null;
		}
	}
}
