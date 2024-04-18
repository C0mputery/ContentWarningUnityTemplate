using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

public class DealProgressUi : MonoBehaviour
{
	public TextMeshProUGUI title;

	public TextMeshProUGUI description;

	public TextMeshProUGUI difficulty;

	public TextMeshProUGUI reward;

	public Image networkIcon;

	public ProceduralImage progress;

	public NetworkDealBase deal;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadDeal(NetworkDealBase deal)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DealProgressUi()
	{

	}
}
