using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	public static class FormatterLocator
	{
		private struct FormatterInfo
		{
			public Type FormatterType;

			public Type TargetType;

			public Type WeakFallbackType;

			public bool AskIfCanFormatTypes;

			public int Priority;
		}

		private struct FormatterLocatorInfo
		{
			public IFormatterLocator LocatorInstance;

			public int Priority;
		}

		[CompilerGenerated]
		private sealed class _003CGetAllPossibleMissingAOTTypes_003Ed__17 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private string _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private Type type;

			public Type _003C_003E3__type;

			private Type[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private Type _003Carg_003E5__4;

			private IEnumerator<string> _003C_003E7__wrap4;

			string IEnumerator<string>.Current
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
			public _003CGetAllPossibleMissingAOTTypes_003Ed__17(int _003C_003E1__state)
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
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<string> IEnumerable<string>.GetEnumerator()
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

		private static readonly object StrongFormatters_LOCK;

		private static readonly object WeakFormatters_LOCK;

		private static readonly Dictionary<Type, IFormatter> FormatterInstances;

		private static readonly DoubleLookupDictionary<Type, ISerializationPolicy, IFormatter> StrongTypeFormatterMap;

		private static readonly DoubleLookupDictionary<Type, ISerializationPolicy, IFormatter> WeakTypeFormatterMap;

		private static readonly List<FormatterLocatorInfo> FormatterLocators;

		private static readonly List<FormatterInfo> FormatterInfos;

		[Obsolete("Use the new IFormatterLocator interface instead, and register your custom locator with the RegisterFormatterLocator assembly attribute.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static event Func<Type, IFormatter> FormatterResolve
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static FormatterLocator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IFormatter<T> GetFormatter<T>(ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IFormatter GetFormatter(Type type, ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IFormatter GetFormatter(Type type, ISerializationPolicy policy, bool allowWeakFallbackFormatters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void LogAOTError(Type type, Exception ex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(_003CGetAllPossibleMissingAOTTypes_003Ed__17))]
		private static IEnumerable<string> GetAllPossibleMissingAOTTypes(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static List<IFormatter> GetAllCompatiblePredefinedFormatters(Type type, ISerializationPolicy policy)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IFormatter CreateFormatter(Type type, ISerializationPolicy policy, bool allowWeakFormatters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IFormatter GetFormatterInstance(Type type)
		{
			throw null;
		}
	}
}
