using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class UploadVideoStation : Interactable
{
	public Item m_flashCardItem;

	public Item m_lostDisk;

	private PhotonView photonView;

	public GameObject m_uploadStateUI;

	public GameObject m_uploadingStateUI;

	public GameObject m_ClosedStateUI;

	public UploadCompleteUI m_uploadCompleteUI;

	private UploadVideoStationStateMachine m_stateMachine;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnSleep()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unlock()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsValid(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UploadLostDisk(int lostDiscIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UploadFlashcard(FlashcardEntry flashcardEntry)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_UploadLostDisc(int lostFootageIndex)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_UploadLostDiscComplete(int handle)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_UploadFlashcard(byte[] videoHandleData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPC_OnEvaluationComplete(float score, byte[] videoHandleData, byte[] commentsData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseVideo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UploadVideoStation()
	{

	}
}
