using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public sealed class RequiredListLengthAttribute : Attribute
	{
		private PrefabKind prefabKind;

		private bool prefabKindIsSet;

		private int minLength;

		private int maxLength;

		private bool minLengthIsSet;

		private bool maxLengthIsSet;

		public string MinLengthGetter;

		public string MaxLengthGetter;

		public int MinLength
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

		public int MaxLength
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

		public bool MinLengthIsSet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool MaxLengthIsSet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool PrefabKindIsSet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public PrefabKind PrefabKind
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
		public RequiredListLengthAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredListLengthAttribute(int fixedLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredListLengthAttribute(int minLength, int maxLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredListLengthAttribute(int minLength, string maxLengthGetter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredListLengthAttribute(string fixedLengthGetter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredListLengthAttribute(string minLengthGetter, string maxLengthGetter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredListLengthAttribute(string minLengthGetter, int maxLength)
		{
			throw null;
		}
	}
}
