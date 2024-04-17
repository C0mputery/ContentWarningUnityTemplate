using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public static class DeepReflection
	{
		private enum PathStepType
		{
			Member = 0,
			WeakListElement = 1,
			StrongListElement = 2,
			ArrayElement = 3
		}

		private struct PathStep
		{
			public readonly PathStepType StepType;

			public readonly MemberInfo Member;

			public readonly int ElementIndex;

			public readonly Type ElementType;

			public readonly MethodInfo StrongListGetItemMethod;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PathStep(MemberInfo member)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PathStep(int elementIndex)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PathStep(int elementIndex, Type strongListElementType, bool isArray)
			{
				throw null;
			}
		}

		private static MethodInfo WeakListGetItem;

		private static MethodInfo WeakListSetItem;

		private static MethodInfo CreateWeakAliasForInstanceGetDelegate1MethodInfo;

		private static MethodInfo CreateWeakAliasForInstanceGetDelegate2MethodInfo;

		private static MethodInfo CreateWeakAliasForStaticGetDelegateMethodInfo;

		private static MethodInfo CreateWeakAliasForInstanceSetDelegate1MethodInfo;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Func<object> CreateWeakStaticValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Func<object, object> CreateWeakInstanceValueGetter(Type rootType, Type resultType, string path, bool allowEmit = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Action<object, object> CreateWeakInstanceValueSetter(Type rootType, Type argType, string path, bool allowEmit = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Func<object, TResult> CreateWeakInstanceValueGetter<TResult>(Type rootType, string path, bool allowEmit = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Func<TResult> CreateValueGetter<TResult>(Type rootType, string path, bool allowEmit = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Func<TTarget, TResult> CreateValueGetter<TTarget, TResult>(string path, bool allowEmit = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object, object> CreateWeakAliasForInstanceGetDelegate1<TTarget, TResult>(Func<TTarget, TResult> func)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object, TResult> CreateWeakAliasForInstanceGetDelegate2<TTarget, TResult>(Func<TTarget, TResult> func)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object> CreateWeakAliasForStaticGetDelegate<TResult>(Func<TResult> func)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Action<object, object> CreateWeakAliasForInstanceSetDelegate1<TTarget, TArg1>(Action<TTarget, TArg1> func)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Action<object, TArg1> CreateWeakAliasForInstanceSetDelegate2<TTarget, TArg1>(Action<TTarget, TArg1> func)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Action<object> CreateWeakAliasForStaticSetDelegate<TArg1>(Action<TArg1> func)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Delegate CreateEmittedDeepValueGetterDelegate(string path, Type rootType, Type resultType, List<PathStep> memberPath, bool rootIsStatic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object> CreateSlowDeepStaticValueGetterDelegate(List<PathStep> memberPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object, object> CreateSlowDeepInstanceValueGetterDelegate(List<PathStep> memberPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Action<object, object> CreateSlowDeepInstanceValueSetterDelegate(List<PathStep> memberPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static object SlowGetMemberValue(PathStep step, object instance)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void SlowSetMemberValue(PathStep step, object instance, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static List<PathStep> GetMemberPath(Type rootType, ref Type resultType, string path, out bool rootIsStatic, bool isSet)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static MemberInfo GetStepMember(Type owningType, string name, bool expectMethod)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DeepReflection()
		{
			throw null;
		}
	}
}
