using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class CustomSerializationPolicy : ISerializationPolicy
	{
		private string id;

		private bool allowNonSerializableTypes;

		private Func<MemberInfo, bool> shouldSerializeFunc;

		public string ID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool AllowNonSerializableTypes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomSerializationPolicy(string id, bool allowNonSerializableTypes, Func<MemberInfo, bool> shouldSerializeFunc)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ShouldSerializeMember(MemberInfo member)
		{
			throw null;
		}
	}
}
