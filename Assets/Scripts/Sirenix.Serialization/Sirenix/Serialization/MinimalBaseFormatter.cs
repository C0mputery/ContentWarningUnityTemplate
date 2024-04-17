using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class MinimalBaseFormatter<T> : IFormatter<T>, IFormatter
	{
		protected static readonly bool IsValueType;

		public Type SerializedType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IFormatter.Serialize(object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		object IFormatter.Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual T GetUninitializedObject()
		{
			throw null;
		}

		protected abstract void Read(ref T value, IDataReader reader);

		protected abstract void Write(ref T value, IDataWriter writer);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RegisterReferenceID(T value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected MinimalBaseFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MinimalBaseFormatter()
		{
			throw null;
		}
	}
}
