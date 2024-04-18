using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public class DisallowAddressableSubAssetFieldAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisallowAddressableSubAssetFieldAttribute()
		{

		}
	}
}
