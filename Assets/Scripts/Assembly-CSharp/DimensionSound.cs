using System.Runtime.CompilerServices;
using UnityEngine;

public class DimensionSound : MonoBehaviour
{
	public float anticipation;

	public float possess;

	public Bot_Skinny reference;

	public SFX_PlayOneShot[] on;

	public SFX_PlayOneShot[] off;

	private bool t;

	private bool t2;

	public AudioLoop possesAudio;

	public AudioLoop possesAudio2;

	public SFX_PlayOneShot anticipationAudio2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DimensionSound()
	{

	}
}
