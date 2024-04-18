using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class OnCollectionChangedAttribute : Attribute
	{
		public string Before;

		public string After;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnCollectionChangedAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnCollectionChangedAttribute(string after)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnCollectionChangedAttribute(string before, string after)
		{

		}
	}
}
