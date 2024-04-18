using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Photon.Voice
{
	public class WebRTCAudioLib
	{
		public enum Error
		{
			kNoError = 0,
			kUnspecifiedError = -1,
			kCreationFailedError = -2,
			kUnsupportedComponentError = -3,
			kUnsupportedFunctionError = -4,
			kNullPointerError = -5,
			kBadParameterError = -6,
			kBadSampleRateError = -7,
			kBadDataLengthError = -8,
			kBadNumberChannelsError = -9,
			kFileError = -10,
			kStreamParameterNotSetError = -11,
			kNotEnabledError = -12,
			kBadStreamParameterWarning = -13
		}

		public enum Param
		{
			REVERSE_STREAM_DELAY_MS = 1,
			AEC = 10,
			AEC_HIGH_PASS_FILTER = 11,
			AECM = 20,
			HIGH_PASS_FILTER = 31,
			NS = 41,
			NS_LEVEL = 42,
			AGC = 51,
			AGC_TARGET_LEVEL_DBFS = 55,
			AGC_COMPRESSION_GAIN = 56,
			AGC_LIMITER = 57,
			VAD = 61,
			VAD_FRAME_SIZE_MS = 62,
			VAD_LIKELIHOOD = 63,
			AGC2 = 71
		}

		private const string lib_name = "webrtc-audio";

		[DllImport("webrtc-audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr webrtc_audio_processor_create(int samplingRate, int channels, int frameSize, int revSamplingRate, int revChannels);

		[DllImport("webrtc-audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int webrtc_audio_processor_init(IntPtr proc);

		[DllImport("webrtc-audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int webrtc_audio_processor_set_param(IntPtr proc, int param, int v);

		[DllImport("webrtc-audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int webrtc_audio_processor_process(IntPtr proc, short[] buffer, int offset, out bool voiceDetected);

		[DllImport("webrtc-audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int webrtc_audio_processor_process_reverse(IntPtr proc, short[] buffer, int bufferSize);

		[DllImport("webrtc-audio", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void webrtc_audio_processor_destroy(IntPtr proc);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebRTCAudioLib()
		{

		}
	}
}
