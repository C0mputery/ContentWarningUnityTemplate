using System.Runtime.CompilerServices;
using Photon.Pun;
using TMPro;
using UnityEngine;

public class SoundPlayerItem : ItemInstanceBehaviour
{
	public SFX_Instance[] sounds;

	private IntRangeEntry selectionEntry;

	private OnOffEntry playingEntry;

	public TextMeshPro numberText;

	public TextMeshPro text;

	public Transform spinner;

	private float counter;

	private int currentNr;

	private bool ready;

	private bool on;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoundPlayerItem()
	{
		throw null;
	}
}
