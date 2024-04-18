using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class JsonTextReader : IDisposable
	{
		private static readonly Dictionary<char, EntryType?> EntryDelineators;

		private static readonly Dictionary<char, char> UnescapeDictionary;

		private StreamReader reader;

		private int bufferIndex;

		private char[] buffer;

		private char? lastReadChar;

		private char? peekedChar;

		private Queue<char> emergencyPlayback;

		public DeserializationContext Context
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public JsonTextReader(Stream stream, DeserializationContext context)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReadToNextEntry(out string name, out string valueContent, out EntryType entry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ParseEntryFromBuffer(out string name, out string valueContent, out EntryType entry, int valueSeparatorIndex, EntryType? hintEntry)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsHex(char c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private uint ParseSingleChar(char c, uint multiplier)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private char ParseHexChar(char c1, char c2, char c3, char c4)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private char ReadCharIntoBuffer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private EntryType? GuessPrimitiveType(string content)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private char PeekChar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SkipChar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private char ConsumeChar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static JsonTextReader()
		{
			throw null;
		}
	}
}
