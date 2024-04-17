using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	[AddComponentMenu("Photon Networking/Photon Animator View")]
	public class PhotonAnimatorView : MonoBehaviourPun, IPunObservable
	{
		public enum ParameterType
		{
			Float = 1,
			Int = 3,
			Bool = 4,
			Trigger = 9
		}

		public enum SynchronizeType
		{
			Disabled = 0,
			Discrete = 1,
			Continuous = 2
		}

		[Serializable]
		public class SynchronizedParameter
		{
			public ParameterType Type;

			public SynchronizeType SynchronizeType;

			public string Name;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SynchronizedParameter()
			{
				throw null;
			}
		}

		[Serializable]
		public class SynchronizedLayer
		{
			public SynchronizeType SynchronizeType;

			public int LayerIndex;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public SynchronizedLayer()
			{
				throw null;
			}
		}

		private bool TriggerUsageWarningDone;

		private Animator m_Animator;

		private PhotonStreamQueue m_StreamQueue;

		[HideInInspector]
		[SerializeField]
		private bool ShowLayerWeightsInspector;

		[HideInInspector]
		[SerializeField]
		private bool ShowParameterInspector;

		[HideInInspector]
		[SerializeField]
		private List<SynchronizedParameter> m_SynchronizeParameters;

		[HideInInspector]
		[SerializeField]
		private List<SynchronizedLayer> m_SynchronizeLayers;

		private Vector3 m_ReceiverPosition;

		private float m_LastDeserializeTime;

		private bool m_WasSynchronizeTypeChanged;

		private List<string> m_raisedDiscreteTriggersCache;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CacheDiscreteTriggers()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DoesLayerSynchronizeTypeExist(int layerIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DoesParameterSynchronizeTypeExist(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<SynchronizedLayer> GetSynchronizedLayers()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<SynchronizedParameter> GetSynchronizedParameters()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SynchronizeType GetLayerSynchronizeType(int layerIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SynchronizeType GetParameterSynchronizeType(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayerSynchronized(int layerIndex, SynchronizeType synchronizeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetParameterSynchronized(string name, ParameterType type, SynchronizeType synchronizeType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeDataContinuously()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeserializeDataContinuously()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeDataDiscretly(PhotonStream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeserializeDataDiscretly(PhotonStream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeSynchronizationTypeState(PhotonStream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeserializeSynchronizationTypeState(PhotonStream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonAnimatorView()
		{
			throw null;
		}
	}
}
