using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

public class PlayerCustomizer : MonoBehaviour
{
	public ProceduralImage headColor;

	public GameObject colorsRoot;

	public GameObject colorSelectorPrefab;

	public Button applyButton;

	public Button quitButton;

	public List<Color> colorsToPickFrom;

	public Player playerInTerminal;

	public TextMeshProUGUI faceText;

	public Button rotateLeftButton;

	public Button rotateRightButton;

	public Button smallerFaceButton;

	public Button biggerFaceButton;

	public int faceSizeStepCount;

	public Vector2 faceSizeMinMax;

	public Vector2 visorFaceSizeMinMax;

	public float startFaceSize;

	public float startFaceRotation;

	private ColorSelector selectedColor;

	private int startColorIndex;

	private string startFaceText;

	private Color startHeadColor;

	private PhotonView view_g;

	public SFX_Instance enterSound;

	public SFX_Instance leaveSound;

	public SFX_Instance clickSound;

	public SFX_Instance typeSound;

	public SFX_Instance backSound;

	public SFX_Instance applySound;

	public SFX_Instance rotateSound;

	public SFX_Instance sizeSound;

	public ColorSelector SelectedColor
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

	public bool HasPlayerInTerminal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float FaceRotation
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

	public float FaceSize
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
	private void RemoveNavigation()
	{
		throw null;
	}

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
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFaceSize(bool smaller)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_ChangeFaceSize(bool smaller)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FaceSizeVisorToUi(float visorSize)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float FaceSizeUiToVisor(float uiSize)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRotate(bool right)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_RotateFaceText(bool right)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnApply()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnQuit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RunTerminal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	private void SetFaceText(string text)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_PickColor(int childNumber)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnterTerminal(PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCM_RequestEnterTerminal(int playerId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_EnterTerminal(int playerId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_SyncEverything(int playerId, int colorIndex, string faceText, float faceRotation, float faceSize)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[PunRPC]
	public void RPCA_PlayerLeftTerminal(bool apply)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SpawnColors()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerCustomizer()
	{

	}
}
