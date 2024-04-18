using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Zorro.Core
{
	[Serializable]
	public sealed class ClassTypeReference : ISerializationCallbackReceiver
	{
		[SerializeField]
		[FormerlySerializedAs("_classRef")]
		private string classRef;

		private Type type;

		public Type Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetClassRef(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassTypeReference()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassTypeReference(string assemblyQualifiedClassName)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ClassTypeReference(Type type)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator string(ClassTypeReference typeReference)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator Type(ClassTypeReference typeReference)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator ClassTypeReference(Type type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
