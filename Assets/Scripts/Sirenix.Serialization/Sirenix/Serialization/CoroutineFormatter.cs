using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Serialization
{
	public sealed class CoroutineFormatter : IFormatter<Coroutine>, IFormatter
	{
		public Type SerializedType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		object IFormatter.Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Coroutine Deserialize(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(object value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(Coroutine value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CoroutineFormatter()
		{

		}
	}
}
