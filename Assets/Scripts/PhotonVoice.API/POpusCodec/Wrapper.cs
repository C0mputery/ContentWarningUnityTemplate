using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using POpusCodec.Enums;
using Photon.Voice;

namespace POpusCodec
{
	internal class Wrapper
	{
		private const string lib_name = "opus_egpv";

		public const bool AsyncAPI = false;

		private const string jsProxyPref = "";

		private const string ctl_entry_point_set = "";

		private const string ctl_entry_point_get = "";

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void opus_encoder_destroy(IntPtr st)
		{
			throw null;
		}

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decode(IntPtr st, IntPtr data, int len, short[] pcm, int frame_size, int decode_fec);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decode_float(IntPtr st, IntPtr data, int len, float[] pcm, int frame_size, int decode_fec);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int opus_decode_async(IntPtr st, IntPtr data, int len, int decodeFEC, bool eos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int opus_decode_float_async(IntPtr st, IntPtr data, int len, int decodeFEC, bool eos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void opus_decoder_destroy(IntPtr st)
		{
			throw null;
		}

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encoder_get_size(Channels channels);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern IntPtr opus_get_version_string();

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "opus_encoder_ctl")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "opus_encoder_ctl")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "opus_decoder_ctl")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "opus_decoder_ctl")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern int opus_decoder_get_size(Channels channels);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int opus_packet_get_bandwidth(IntPtr data);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[DllImport("opus_egpv", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels, Action<IntPtr, bool> dataCallbackStatic = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int opus_decode(IntPtr st, FrameBuffer data, short[] pcm, int frame_size, int decode_fec)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int opus_decode(IntPtr st, FrameBuffer data, float[] pcm, int frame_size, int decode_fec)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void HandleStatusCode(OpusStatusCode statusCode, params object[] info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Wrapper()
		{
			throw null;
		}
	}
}
