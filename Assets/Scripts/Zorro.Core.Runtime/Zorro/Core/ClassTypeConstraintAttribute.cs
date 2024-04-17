using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public abstract class ClassTypeConstraintAttribute : PropertyAttribute
	{
		private ClassGrouping grouping;

		private bool allowAbstract;

		public ClassGrouping Grouping
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

		public bool AllowAbstract
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
		public virtual bool IsConstraintSatisfied(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ClassTypeConstraintAttribute()
		{
			throw null;
		}
	}
}
