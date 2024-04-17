using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class DisableContextMenuAttribute : Attribute
	{
		public bool DisableForMember;

		public bool DisableForCollectionElements;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DisableContextMenuAttribute(bool disableForMember = true, bool disableCollectionElements = false)
		{
			throw null;
		}
	}
}
