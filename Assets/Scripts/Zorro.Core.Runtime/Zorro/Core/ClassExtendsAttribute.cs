using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class ClassExtendsAttribute : ClassTypeConstraintAttribute
	{
		public Type BaseType
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
		public ClassExtendsAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassExtendsAttribute(Type baseType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsConstraintSatisfied(Type type)
		{
			throw null;
		}
	}
}
