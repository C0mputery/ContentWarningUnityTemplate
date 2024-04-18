using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class DelegateFormatter<T> : BaseFormatter<T> where T : class
	{
		private static readonly Serializer<object> ObjectSerializer;

		private static readonly Serializer<string> StringSerializer;

		private static readonly Serializer<Type> TypeSerializer;

		private static readonly Serializer<Type[]> TypeArraySerializer;

		private static readonly Serializer<Delegate[]> DelegateArraySerializer;

		public readonly Type DelegateType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelegateFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DelegateFormatter(Type delegateType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref T value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SerializeImplementation(ref T value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override T GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DelegateFormatter()
		{
			throw null;
		}
	}
}
