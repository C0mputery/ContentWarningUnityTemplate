using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class SingleSerializer : Serializer<float>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override float ReadValue(IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void WriteValue(string name, float value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SingleSerializer()
		{
			throw null;
		}
	}
}
