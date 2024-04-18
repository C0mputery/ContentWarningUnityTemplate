using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class WeakMinimalBaseFormatter : IFormatter
	{
		protected readonly Type SerializedType;

		protected readonly bool IsValueType;

		Type IFormatter.SerializedType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakMinimalBaseFormatter(Type serializedType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual object GetUninitializedObject()
		{
			throw null;
		}

		protected abstract void Read(ref object value, IDataReader reader);

		protected abstract void Write(ref object value, IDataWriter writer);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RegisterReferenceID(object value, IDataReader reader)
		{
			throw null;
		}
	}
}
