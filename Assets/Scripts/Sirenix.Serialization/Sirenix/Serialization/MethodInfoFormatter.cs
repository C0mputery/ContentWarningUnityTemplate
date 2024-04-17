using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class MethodInfoFormatter<T> : BaseFormatter<T> where T : MethodInfo
	{
		private static readonly Serializer<string> StringSerializer;

		private static readonly Serializer<Type> TypeSerializer;

		private static readonly Serializer<Type[]> TypeArraySerializer;

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
		public MethodInfoFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static MethodInfoFormatter()
		{
			throw null;
		}
	}
}
