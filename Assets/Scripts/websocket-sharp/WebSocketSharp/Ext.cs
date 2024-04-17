using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using WebSocketSharp.Net;

namespace WebSocketSharp
{
	public static class Ext
	{
		private static readonly byte[] _last;

		private static readonly int _retry;

		private const string _tspecials = "()<>@,;:\\\"/[]?={} \t";

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] compress(this byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MemoryStream compress(this Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] compressToArray(this Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] decompress(this byte[] data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MemoryStream decompress(this Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static byte[] decompressToArray(this Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isHttpMethod(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isHttpMethod10(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isPredefinedScheme(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] Append(this ushort code, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] Compress(this byte[] data, CompressionMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Stream Compress(this Stream stream, CompressionMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] CompressToArray(this Stream stream, CompressionMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Contains(this string value, params char[] anyOf)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Contains(this NameValueCollection collection, string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Contains(this NameValueCollection collection, string name, string value, StringComparison comparisonTypeForValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Contains<T>(this IEnumerable<T> source, Func<T, bool> condition)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool ContainsTwice(this string[] values)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static T[] Copy<T>(this T[] sourceArray, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static T[] Copy<T>(this T[] sourceArray, long length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CopyTo(this Stream sourceStream, Stream destinationStream, int bufferLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CopyToAsync(this Stream sourceStream, Stream destinationStream, int bufferLength, Action completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] Decompress(this byte[] data, CompressionMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static Stream Decompress(this Stream stream, CompressionMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] DecompressToArray(this Stream stream, CompressionMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Emit(this EventHandler eventHandler, object sender, EventArgs e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void Emit<TEventArgs>(this EventHandler<TEventArgs> eventHandler, object sender, TEventArgs e) where TEventArgs : EventArgs
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetAbsolutePath(this Uri uri)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static WebSocketSharp.Net.CookieCollection GetCookies(this NameValueCollection headers, bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetDnsSafeHost(this Uri uri, bool bracketIPv6)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetMessage(this CloseStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetName(this string nameAndValue, char separator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetUTF8DecodedString(this byte[] bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] GetUTF8EncodedBytes(this string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetValue(this string nameAndValue, char separator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string GetValue(this string nameAndValue, char separator, bool unquote)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsCompressionExtension(this string value, CompressionMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsControl(this byte opcode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsControl(this Opcode opcode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsData(this byte opcode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsData(this Opcode opcode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsEqualTo(this int value, char c, Action<int> beforeComparing)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsHttpMethod(this string value, Version version)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsPortNumber(this int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsReserved(this ushort code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsReserved(this CloseStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsSupported(this byte opcode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsText(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IsToken(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KeepsAlive(this NameValueCollection headers, Version version)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool MaybeUri(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string Quote(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] ReadBytes(this Stream stream, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] ReadBytes(this Stream stream, long length, int bufferLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ReadBytesAsync(this Stream stream, int length, Action<byte[]> completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ReadBytesAsync(this Stream stream, long length, int bufferLength, Action<byte[]> completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static T[] Reverse<T>(this T[] array)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IEnumerable<string> SplitHeaderValue(this string value, params char[] separators)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] ToByteArray(this Stream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] ToByteArray(this ushort value, ByteOrder order)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static byte[] ToByteArray(this ulong value, ByteOrder order)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CompressionMethod ToCompressionMethod(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string ToExtensionString(this CompressionMethod method, params string[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IPAddress ToIPAddress(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string ToString(this IPAddress address, bool bracketIPv6)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ushort ToUInt16(this byte[] source, ByteOrder sourceOrder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ulong ToUInt64(this byte[] source, ByteOrder sourceOrder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IEnumerable<string> TrimEach(this IEnumerable<string> source)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string TrimSlashFromEnd(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string TrimSlashOrBackslashFromEnd(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryCreateVersion(this string versionString, out Version result)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryCreateWebSocketUri(this string uriString, out Uri result, out string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryGetUTF8DecodedString(this byte[] bytes, out string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryGetUTF8EncodedBytes(this string s, out byte[] bytes)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool TryOpenRead(this FileInfo fileInfo, out FileStream fileStream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string Unquote(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Upgrades(this NameValueCollection headers, string protocol)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string UrlDecode(this string value, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string UrlEncode(this string value, Encoding encoding)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WriteBytes(this Stream stream, byte[] bytes, int bufferLength)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void WriteBytesAsync(this Stream stream, byte[] bytes, int bufferLength, Action completed, Action<Exception> error)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetDescription(this WebSocketSharp.Net.HttpStatusCode code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetStatusDescription(this int code)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsCloseStatusCode(this ushort value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsEnclosedIn(this string value, char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsHostOrder(this ByteOrder order)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsLocal(this IPAddress address)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsNullOrEmpty(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T[] SubArray<T>(this T[] array, int startIndex, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T[] SubArray<T>(this T[] array, long startIndex, long length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Times(this int n, Action<int> action)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Times(this long n, Action<long> action)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte[] ToHostOrder(this byte[] source, ByteOrder sourceOrder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ToString<T>(this T[] array, string separator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Uri ToUri(this string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Ext()
		{
			throw null;
		}
	}
}
