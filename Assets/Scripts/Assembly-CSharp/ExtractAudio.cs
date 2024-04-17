using System.Runtime.CompilerServices;
using UnityEngine;

public class ExtractAudio : MonoBehaviour
{
	public ExtractVideoMachine extract;

	public GameObject extractSound;

	public GameObject errorSound;

	public ExtractVideoStationHatch hatch;

	public SFX_Instance hatchClose;

	public SFX_Instance hatchOpen;

	private bool prevOpenHatch;

	public CDRom rom;

	private bool prevOpenRom;

	public SFX_Instance romClose;

	public SFX_Instance romOpen;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractAudio()
	{
		throw null;
	}
}
