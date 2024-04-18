using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class BufferReaderPushAdapterAsyncPoolShortToFloat : BufferReaderPushAdapterBase<short>
	{
		private short[] buffer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferReaderPushAdapterAsyncPoolShortToFloat(IDataReader<short> reader) : base(null)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Service(LocalVoice localVoice)
		{
			throw null;
		}
	}
}
