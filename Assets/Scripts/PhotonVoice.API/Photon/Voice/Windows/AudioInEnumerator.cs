using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Photon.Voice.Windows
{
	public class AudioInEnumerator : DeviceEnumeratorBase
	{
		private const string lib_name = "AudioIn";

		private IntPtr handle;

		[DllImport("AudioIn")]
		private static extern IntPtr Photon_Audio_In_CreateMicEnumerator();

		[DllImport("AudioIn")]
		private static extern void Photon_Audio_In_DestroyMicEnumerator(IntPtr handle);

		[DllImport("AudioIn")]
		private static extern int Photon_Audio_In_MicEnumerator_Count(IntPtr handle);

		[DllImport("AudioIn")]
		private static extern IntPtr Photon_Audio_In_MicEnumerator_NameAtIndex(IntPtr handle, int idx);

		[DllImport("AudioIn")]
		private static extern int Photon_Audio_In_MicEnumerator_IDAtIndex(IntPtr handle, int idx);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioInEnumerator(ILogger logger) : base(null)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Refresh()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}
	}
}
