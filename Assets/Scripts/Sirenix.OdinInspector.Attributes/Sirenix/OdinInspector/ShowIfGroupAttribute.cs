using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public class ShowIfGroupAttribute : PropertyGroupAttribute
	{
		public object Value;

		public bool Animate
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

		[Obsolete("Use the Condition member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
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

		public string Condition
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
		public ShowIfGroupAttribute(string path, bool animate = true) : base(path)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShowIfGroupAttribute(string path, object value, bool animate = true) : base(path)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
			throw null;
		}
	}
}
