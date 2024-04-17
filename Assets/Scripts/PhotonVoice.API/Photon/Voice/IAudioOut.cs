namespace Photon.Voice
{
	public interface IAudioOut<T>
	{
		bool IsPlaying { get; }

		int Lag { get; }

		void Start(int frequency, int channels, int frameSamplesPerChannel);

		void Flush();

		void Stop();

		void Push(T[] frame);

		void Service();
	}
}
