using System.Runtime.CompilerServices;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EscapePlayerCellUI : MonoBehaviour
{
	public Image playerIcon;

	public TextMeshProUGUI playerName;

	public Slider playerVoiceVolume;

	private GlobalPlayerData globalPlayerData;

	private Photon.Realtime.Player m_player;

	private bool loadedVolume;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Setup(Photon.Realtime.Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EscapePlayerCellUI()
	{
		throw null;
	}
}
