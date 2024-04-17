using System.Runtime.CompilerServices;
using Sirenix.Serialization;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	public abstract class SerializedScriptableObject : ScriptableObject, ISerializationCallbackReceiver
	{
		[SerializeField]
		[HideInInspector]
		private SerializationData serializationData;

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
		protected virtual void OnAfterDeserialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnBeforeSerialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected SerializedScriptableObject()
		{
			throw null;
		}
	}
}
