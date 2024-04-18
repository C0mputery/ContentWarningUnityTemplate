using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ExitGames.Client.Photon
{
	public class SupportClass
	{
		[Obsolete("Use a Stopwatch (or equivalent) instead.")]
		public delegate int IntegerMillisecondsDelegate();

		public class ThreadSafeRandom
		{
			private static readonly Random _r;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static int Next()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public ThreadSafeRandom()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static ThreadSafeRandom()
			{
				throw null;
			}
		}

		private static List<Thread> threadList;

		private static readonly object ThreadListLock;

		[Obsolete("Use a Stopwatch (or equivalent) instead.")]
		protected internal static IntegerMillisecondsDelegate IntegerMilliseconds;

		private static uint[] crcLookupTable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<MethodInfo> GetMethods(Type type, Type attribute)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use a Stopwatch (or equivalent) instead.")]
		public static int GetTickCount()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte StartBackgroundCalls(Func<bool> myThread, int millisecondsInterval = 100, string taskName = "")
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool StopBackgroundCalls(byte id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool StopAllBackgroundCalls()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteStackTrace(Exception throwable, TextWriter stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void WriteStackTrace(Exception throwable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string DictionaryToString(IDictionary dictionary, bool includeTypes = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string DictionaryToString(NonAllocDictionary<byte, object> dictionary, bool includeTypes = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Use DictionaryToString() instead.")]
		public static string HashtableToString(Hashtable hash)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string ByteArrayToString(byte[] list, int length = -1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static uint[] InitializeTable(uint polynomial)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static uint CalculateCrc(byte[] buffer, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SupportClass()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SupportClass()
		{
			throw null;
		}
	}
}
