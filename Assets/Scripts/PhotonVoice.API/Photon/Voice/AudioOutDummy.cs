using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class AudioOutDummy<T> : IAudioOut<T>
	{
		public bool IsPlaying
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Lag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Flush()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Push(T[] frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Service()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start(int frequency, int channels, int frameSamplesPerChannel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stop()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioOutDummy()
		{

		}
	}
}
