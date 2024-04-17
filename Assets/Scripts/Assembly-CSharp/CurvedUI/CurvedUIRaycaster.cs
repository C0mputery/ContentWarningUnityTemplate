using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CurvedUI
{
	public class CurvedUIRaycaster : GraphicRaycaster
	{
		[SerializeField]
		private bool showDebug;

		private bool overrideEventData;

		private Canvas myCanvas;

		private CurvedUISettings mySettings;

		private Vector3 cyllinderMidPoint;

		private List<GameObject> objectsUnderPointer;

		private Vector2 lastCanvasPos;

		private GameObject colliderContainer;

		private PointerEventData lastFrameEventData;

		private PointerEventData curEventData;

		private PointerEventData eventDataToUse;

		private Ray cachedRay;

		private Graphic gph;

		private List<GameObject> selectablesUnderGaze;

		private List<GameObject> selectablesUnderGazeLastFrame;

		private float objectsUnderGazeLastChangeTime;

		private bool gazeClickExecuted;

		private bool pointingAtCanvas;

		private bool pointingAtCanvasLastFrame;

		[NonSerialized]
		private List<Graphic> m_RaycastResults;

		[NonSerialized]
		private static readonly List<Graphic> s_SortedGraphics;

		private Image GazeProgressImage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool PointingAtCanvas
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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
		private void ProcessGazeTimedClick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetGazeTimedClick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool RaycastToCyllinderCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool RaycastToCyllinderVerticalCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool RaycastToRingCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool RaycastToSphereCanvas(Ray ray3D, out Vector2 o_canvasPos, bool OutputInCanvasSpace = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FlatRaycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void FlatRaycastAndSort(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CreateCollider()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupMeshColliderUsingMesh(Mesh meshie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private GameObject CreateConvexCyllinderCollider(bool vertical = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Mesh CreateCyllinderColliderMesh(bool vertical = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Mesh CreateSphereColliderMesh()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsInLayerMask(int layer, LayerMask layermask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private LayerMask GetRaycastLayerMask()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float AngleSigned(Vector3 v1, Vector3 v2, Vector3 n)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateSelectedObjects(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool GetScreenSpacePointByRay(Ray ray, out Vector2 o_positionOnCanvas)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckEventCamera()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RebuildCollider()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<GameObject> GetObjectsUnderPointer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<GameObject> GetObjectsUnderScreenPos(Vector2 screenPos, Camera eventCamera = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<GameObject> GetObjectsHitByRay(Ray ray)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Click()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ModifyQuad(List<Vector3> verts, int vertexIndex, Vector2 requiredSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 TesselateQuad(List<Vector3> quad, float x, float y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUIRaycaster()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static CurvedUIRaycaster()
		{
			throw null;
		}
	}
}
