using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class CustomValueDrawerAttribute : Attribute
	{
		public string Action;

		[Obsolete("Use the Action member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MethodName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomValueDrawerAttribute(string action)
		{

		}
	}
}
