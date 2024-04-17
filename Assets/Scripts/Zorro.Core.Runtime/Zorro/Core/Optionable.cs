using System;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public readonly struct Optionable<T> : IEquatable<Optionable<T>> where T : struct
	{
		private readonly T value;

		private readonly byte hasValue;

		public T Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static Optionable<T> None
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsSome
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsNone
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Optionable<T> NoneWithValue(T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Optionable<T> Some(T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Optionable(T value, byte hasValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T ValueOr(T other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(Optionable<T> other)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator ==(Optionable<T> left, Optionable<T> right)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator !=(Optionable<T> left, Optionable<T> right)
		{
			throw null;
		}
	}
}
