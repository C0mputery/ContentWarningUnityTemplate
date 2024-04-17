using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class SerializationConfig
	{
		private readonly object LOCK;

		private volatile ISerializationPolicy serializationPolicy;

		private volatile DebugContext debugContext;

		public bool AllowDeserializeInvalidData;

		public ISerializationPolicy SerializationPolicy
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

		public DebugContext DebugContext
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
		public SerializationConfig()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetToDefault()
		{
			throw null;
		}
	}
}
