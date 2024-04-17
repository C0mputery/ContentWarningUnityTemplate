using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public static class DictionaryKeyUtility
	{
		private class UnityObjectKeyComparer<T> : IComparer<T>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(T x, T y)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public UnityObjectKeyComparer()
			{
				throw null;
			}
		}

		private class FallbackKeyComparer<T> : IComparer<T>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(T x, T y)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FallbackKeyComparer()
			{
				throw null;
			}
		}

		public class KeyComparer<T> : IComparer<T>
		{
			public static readonly KeyComparer<T> Default;

			private readonly IComparer<T> actualComparer;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public KeyComparer()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int Compare(T x, T y)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			static KeyComparer()
			{
				throw null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetPersistentPathKeyTypes_003Ed__14 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private Type _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private HashSet<Type>.Enumerator _003C_003E7__wrap1;

			private Dictionary<Type, IDictionaryKeyPathProvider>.KeyCollection.Enumerator _003C_003E7__wrap2;

			Type IEnumerator<Type>.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[DebuggerHidden]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			public _003CGetPersistentPathKeyTypes_003Ed__14(int _003C_003E1__state)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool MoveNext()
			{
				throw null;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void _003C_003Em__Finally1()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void _003C_003Em__Finally2()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				throw null;
			}
		}

		private static readonly Dictionary<Type, bool> GetSupportedDictionaryKeyTypesResults;

		private static readonly HashSet<Type> BaseSupportedDictionaryKeyTypes;

		private static readonly HashSet<char> AllowedSpecialKeyStrChars;

		private static readonly Dictionary<Type, IDictionaryKeyPathProvider> TypeToKeyPathProviders;

		private static readonly Dictionary<string, IDictionaryKeyPathProvider> IDToKeyPathProviders;

		private static readonly Dictionary<IDictionaryKeyPathProvider, string> ProviderToID;

		private static readonly Dictionary<object, string> ObjectsToTempKeys;

		private static readonly Dictionary<string, object> TempKeysToObjects;

		private static long tempKeyCounter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DictionaryKeyUtility()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void LogInvalidKeyPathProvider(Type type, Assembly assembly, string reason)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CGetPersistentPathKeyTypes_003Ed__14))]
		public static IEnumerable<Type> GetPersistentPathKeyTypes()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool KeyTypeSupportsPersistentPaths(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool PrivateIsSupportedDictionaryKeyType(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetDictionaryKeyString(object key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object GetDictionaryKeyValue(string keyStr, Type expectedType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string FromTo(this string str, int from, int to)
		{
			throw null;
		}
	}
}
