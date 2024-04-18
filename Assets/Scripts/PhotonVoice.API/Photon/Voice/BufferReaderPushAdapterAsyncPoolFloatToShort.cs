using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		private float[] buffer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(IDataReader<float> reader) : base(null)
		{

        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Service(LocalVoice localVoice)
		{
			throw null;
		}
	}
}
