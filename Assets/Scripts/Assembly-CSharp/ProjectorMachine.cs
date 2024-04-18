using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

public class ProjectorMachine : MonoBehaviour
{
	public SFX_Instance offSound;

	public SFX_Instance onSound;

	public AudioLoop loop;

	public SFX_Instance flip;

	public MeshRenderer rend;

	public Texture2D[] textures;

	private int currentID;

	private int prevInt;

	private PhotonView view;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PressLess()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PressMore()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_Press(bool more)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ProjectorMachine()
	{

	}
}
