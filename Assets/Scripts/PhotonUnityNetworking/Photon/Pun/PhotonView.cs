using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.Serialization;

namespace Photon.Pun
{
	[AddComponentMenu("Photon Networking/Photon View")]
	public class PhotonView : MonoBehaviour
	{
		public enum ObservableSearch
		{
			Manual = 0,
			AutoFindActive = 1,
			AutoFindAll = 2
		}

		private struct CallbackTargetChange
		{
			public IPhotonViewCallback obj;

			public Type type;

			public bool add;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public CallbackTargetChange(IPhotonViewCallback obj, Type type, bool add)
			{
				throw null;
			}
		}

		[FormerlySerializedAs("group")]
		public byte Group;

		[FormerlySerializedAs("prefixBackup")]
		public int prefixField;

		internal object[] instantiationDataField;

		protected internal List<object> lastOnSerializeDataSent;

		protected internal List<object> syncValues;

		protected internal object[] lastOnSerializeDataReceived;

		[FormerlySerializedAs("synchronization")]
		public ViewSynchronization Synchronization;

		protected internal bool mixedModeIsReliable;

		[FormerlySerializedAs("ownershipTransfer")]
		public OwnershipOption OwnershipTransfer;

		public ObservableSearch observableSearch;

		public List<Component> ObservedComponents;

		internal MonoBehaviour[] RpcMonoBehaviours;

		[NonSerialized]
		private int ownerActorNr;

		[NonSerialized]
		private int controllerActorNr;

		[SerializeField]
		[FormerlySerializedAs("viewIdField")]
		[HideInInspector]
		public int sceneViewId;

		[NonSerialized]
		private int viewIdField;

		[FormerlySerializedAs("instantiationId")]
		public int InstantiationId;

		[SerializeField]
		[HideInInspector]
		public bool isRuntimeInstantiated;

		protected internal bool removedFromLocalViewList;

		private Queue<CallbackTargetChange> CallbackChangeQueue;

		private List<IOnPhotonViewPreNetDestroy> OnPreNetDestroyCallbacks;

		private List<IOnPhotonViewOwnerChange> OnOwnerChangeCallbacks;

		private List<IOnPhotonViewControllerChange> OnControllerChangeCallbacks;

		public int Prefix
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

		public object[] InstantiationData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected internal set
			{
				throw null;
			}
		}

		[Obsolete("Renamed. Use IsRoomView instead")]
		public bool IsSceneView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsRoomView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsOwnerActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsMine
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

		public bool AmController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Player Controller
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

		public int CreatorActorNr
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

		public bool AmOwner
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

		public Player Owner
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

		public int OwnerActorNr
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

		public int ControllerActorNr
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

		public int ViewID
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
		protected internal void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void ResetPhotonView(bool resetOwner)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void RebuildControllerCache(bool ownerHasChanged = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPreNetDestroy(PhotonView rootView)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RequestOwnership()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TransferOwnership(Player newOwner)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TransferOwnership(int newOwnerId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FindObservables(bool force = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeserializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void DeserializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected internal void SerializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshRpcMonoBehaviourCache()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RpcSecure(string methodName, RpcTarget target, bool encrypt, params object[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RPC(string methodName, Player targetPlayer, params object[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RpcSecure(string methodName, Player targetPlayer, bool encrypt, params object[] parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PhotonView Get(Component component)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PhotonView Get(GameObject gameObj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static PhotonView Find(int viewID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCallbackTarget(IPhotonViewCallback obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveCallbackTarget(IPhotonViewCallback obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddCallback<T>(IPhotonViewCallback obj) where T : class, IPhotonViewCallback
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveCallback<T>(IPhotonViewCallback obj) where T : class, IPhotonViewCallback
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateCallbackLists()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TryRegisterCallback<T>(IPhotonViewCallback obj, ref List<T> list, bool add) where T : class, IPhotonViewCallback
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RegisterCallback<T>(T obj, ref List<T> list, bool add) where T : class, IPhotonViewCallback
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonView()
		{
			throw null;
		}
	}
}
