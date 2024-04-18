using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class MonoPInvokeCallbackAttribute : Attribute
	{
		private Type type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonoPInvokeCallbackAttribute(Type t)
		{

		}
	}
}
