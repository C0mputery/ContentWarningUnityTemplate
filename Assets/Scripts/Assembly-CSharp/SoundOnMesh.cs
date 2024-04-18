using System.Runtime.CompilerServices;
using UnityEngine;

public class SoundOnMesh : MonoBehaviour
{
	public Renderer reference;

	public Light lightRef;

	public SFX_PlayOneShot[] on;

	public SFX_PlayOneShot[] off;

	public GameObject[] onObject;

	public GameObject[] offObject;

	private bool t;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoundOnMesh()
	{

	}
}
