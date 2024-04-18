using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class ReflectionFormatter<T> : BaseFormatter<T>
	{
		public ISerializationPolicy OverridePolicy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReflectionFormatter()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReflectionFormatter(ISerializationPolicy overridePolicy)
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
	}
}
