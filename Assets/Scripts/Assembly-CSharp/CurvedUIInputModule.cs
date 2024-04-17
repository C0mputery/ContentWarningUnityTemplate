using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CurvedUIInputModule : StandaloneInputModule
{
	public enum CUIControlMethod
	{
		MOUSE = 0,
		GAZE = 1,
		WORLD_MOUSE = 2,
		CUSTOM_RAY = 3,
		STEAMVR_LEGACY = 4,
		OCULUSVR = 5,
		STEAMVR_2 = 8,
		UNITY_XR = 9
	}

	public enum Hand
	{
		Both = 0,
		Right = 1,
		Left = 2
	}

	[SerializeField]
	private CUIControlMethod controlMethod;

	[SerializeField]
	private string submitButtonName;

	[SerializeField]
	private Camera mainEventCamera;

	[SerializeField]
	private LayerMask raycastLayerMask;

	[SerializeField]
	private bool gazeUseTimedClick;

	[SerializeField]
	private float gazeClickTimer;

	[SerializeField]
	private float gazeClickTimerDelay;

	[SerializeField]
	private Image gazeTimedClickProgressImage;

	[SerializeField]
	private float worldSpaceMouseSensitivity;

	[SerializeField]
	private Hand usedHand;

	[SerializeField]
	private Transform pointerTransformOverride;

	private static bool disableOtherInputModulesOnStart;

	private static CurvedUIInputModule instance;

	private GameObject currentDragging;

	private GameObject currentPointedAt;

	private GameObject m_rightController;

	private GameObject m_leftController;

	private float gazeTimerProgress;

	private Ray customControllerRay;

	private float dragThreshold;

	private bool pressedDown;

	private bool pressedLastFrame;

	private Vector2 lastEventDataPosition;

	private MouseButtonEventData storedData;

	private Vector3 lastMouseOnScreenPos;

	private Vector2 worldSpaceMouseInCanvasSpace;

	private Vector2 lastWorldSpaceMouseOnCanvas;

	private Vector2 worldSpaceMouseOnCanvasDelta;

	public static CurvedUIInputModule Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public static bool CanInstanceBeAccessed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static CUIControlMethod ControlMethod
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

	public LayerMask RaycastLayerMask
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

	public Hand UsedHand
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

	public Transform ControllerTransform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Vector3 ControllerPointingDirection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Vector3 ControllerPointingOrigin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Transform PointerTransformOverride
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

	public GameObject CurrentPointedAt
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Camera EventCamera
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

	public static Vector2 MousePosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static bool LeftMouseButton
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static Ray CustomControllerRay
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

	public static bool CustomControllerButtonState
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

	[Obsolete("Use CustomControllerButtonState instead.")]
	public static bool CustomControllerButtonDown
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

	public Vector2 WorldSpaceMouseInCanvasSpace
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

	public Vector2 WorldSpaceMouseInCanvasSpaceDelta
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float WorldSpaceMouseSensitivity
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

	public bool GazeUseTimedClick
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

	public float GazeClickTimer
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

	public float GazeClickTimerDelay
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

	public float GazeTimerProgress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Image GazeTimedClickProgressImage
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
	protected override void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Process()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ProcessGaze()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ProcessCustomRayController()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override MouseState GetMousePointerEventData(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ProcessDrag(PointerEventData pointerEvent)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private PointerEventData.FramePressState CustomRayFramePressedState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ProcessViveControllers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ScanForOculusPrefabs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ProcessOculusVRController()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ProcessSteamVR2Controllers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T EnableInputModule<T>() where T : BaseInputModule
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ray GetEventRay(Camera eventCam = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CurvedUIInputModule()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static CurvedUIInputModule()
	{
		throw null;
	}
}
