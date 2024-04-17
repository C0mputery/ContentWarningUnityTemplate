using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ExitGames.Client.Photon.StructWrapping
{
	public abstract class StructWrapper : IDisposable
	{
		public readonly WrappedType wrappedType;

		public readonly Type ttype;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper(Type ttype, WrappedType wrappedType)
		{
			throw null;
		}

		public abstract object Box();

		public abstract void DisconnectFromPool();

		public abstract void Dispose();

		public abstract string ToString(bool writeType);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(double value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator bool(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator byte(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator float(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator double(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator short(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator int(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator long(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(Vector2 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(Vector3 value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper(Quaternion value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator Vector2(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator Vector3(StructWrapper wrapper)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator Quaternion(StructWrapper wrapper)
		{
			throw null;
		}
	}

	public class StructWrapper<T> : StructWrapper
	{
		internal Pooling pooling;

		internal T value;

		internal static StructWrapperPool<T> staticPool;

		public StructWrapperPool<T> ReturnPool
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<T> Poke(byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<T> Poke(bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StructWrapper<T> Poke(T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Unwrap()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Peek()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object Box()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DisconnectFromPool()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString(bool writeTypeInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator StructWrapper<T>(T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static StructWrapper()
		{
			throw null;
		}

        public StructWrapper(Type ttype, WrappedType wrappedType) : base(ttype, wrappedType)
        {
        }
    }
}
