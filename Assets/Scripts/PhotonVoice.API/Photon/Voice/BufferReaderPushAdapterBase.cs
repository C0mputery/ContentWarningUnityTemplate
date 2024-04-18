using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		protected IDataReader<T> reader;

		public abstract void Service(LocalVoice localVoice);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
