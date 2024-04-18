using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class EmittedAssemblyAttribute : Attribute
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("This attribute cannot be used in code, and is only meant to be applied to dynamically emitted assemblies.", true)]
		public EmittedAssemblyAttribute()
		{

		}
	}
}
