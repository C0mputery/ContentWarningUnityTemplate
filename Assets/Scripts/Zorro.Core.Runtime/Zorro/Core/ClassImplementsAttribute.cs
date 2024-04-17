using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class ClassImplementsAttribute : ClassTypeConstraintAttribute
	{
		public Type InterfaceType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassImplementsAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassImplementsAttribute(Type interfaceType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsConstraintSatisfied(Type type)
		{
			throw null;
		}
	}
}
