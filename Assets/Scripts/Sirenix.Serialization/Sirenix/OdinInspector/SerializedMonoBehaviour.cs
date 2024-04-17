using System.Runtime.CompilerServices;
using Sirenix.Serialization;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	public abstract class SerializedMonoBehaviour : MonoBehaviour, ISerializationCallbackReceiver, ISupportsPrefabSerialization
	{
		[SerializeField]
		[HideInInspector]
		private SerializationData serializationData;

		SerializationData ISupportsPrefabSerialization.SerializationData
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
		protected SerializedMonoBehaviour()
		{
			throw null;
		}
	}
}
