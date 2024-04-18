using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class AnySerializer : Serializer
	{
		private static readonly ISerializationPolicy UnityPolicy;

		private static readonly ISerializationPolicy StrictPolicy;

		private static readonly ISerializationPolicy EverythingPolicy;

		private readonly Type SerializedType;

		private readonly bool IsEnum;

		private readonly bool IsValueType;

		private readonly bool MayBeBoxedValueType;

		private readonly bool IsAbstract;

		private readonly bool IsNullable;

		private readonly bool AllowDeserializeInvalidData;

		private IFormatter UnityPolicyFormatter;

		private IFormatter StrictPolicyFormatter;

		private IFormatter EverythingPolicyFormatter;

		private readonly Dictionary<ISerializationPolicy, IFormatter> FormattersByPolicy;

		private readonly object FormattersByPolicy_LOCK;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnySerializer(Type serializedType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object ReadValueWeak(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValueWeak(string name, object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IFormatter GetBaseFormatter(ISerializationPolicy serializationPolicy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static AnySerializer()
		{
			throw null;
		}
	}
}
