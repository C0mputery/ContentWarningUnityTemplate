using System;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public class AudioInChangeNotifierNotSupported : IAudioInChangeNotifier, IDisposable
	{
		public bool IsSupported
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioInChangeNotifierNotSupported(Action callback, ILogger logger)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}
	}
}
