using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Photon.Voice.Unity.UtilityScripts
{
	public class WaveWriter : IDisposable
	{
		private readonly long _waveStartPosition;

		private int _dataLength;

		private bool _isDisposed;

		private Stream _stream;

		private BinaryWriter _writer;

		private int _sampleRate;

		private int _bitsPerSample;

		private int _channels;

		private readonly bool _closeStream;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaveWriter(string fileName, int sampleRate, int bits, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaveWriter(Stream stream, int sampleRate, int bitsPerSample, int channels)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteSample(float sample)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteSamples(float[] samples, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Write(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void WriteHeader()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		~WaveWriter()
		{
			throw null;
		}
	}
}
