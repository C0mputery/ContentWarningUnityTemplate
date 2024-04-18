using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakDelegateFormatter : DelegateFormatter<Delegate>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakDelegateFormatter(Type delegateType)
		{

		}
	}
}
