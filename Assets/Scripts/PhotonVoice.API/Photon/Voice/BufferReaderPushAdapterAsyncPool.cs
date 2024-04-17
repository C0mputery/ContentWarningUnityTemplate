using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferReaderPushAdapterAsyncPool(IDataReader<T> reader) : base(null)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Service(LocalVoice localVoice)
		{
			throw null;
		}
	}
}
