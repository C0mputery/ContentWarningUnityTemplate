using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CurvedUI
{
	[DisallowMultipleComponent]
	public class CurvedUIVertexEffect : BaseMeshEffect
	{
		[Tooltip("Check to skip tesselation pass on this object. CurvedUI will not create additional vertices to make this object have a smoother curve. Checking this can solve some issues if you create your own procedural mesh for this object. Default false.")]
		public bool DoNotTesselate;

		private Canvas myCanvas;

		private CurvedUISettings mySettings;

		private Graphic myGraphic;

		private Text myText;

		private TextMeshProUGUI myTMP;

		private CurvedUITMPSubmesh myTMPSubMesh;

		private bool m_tesselationRequired;

		private bool curvingRequired;

		private bool TransformMisaligned;

		private Matrix4x4 CanvasToWorld;

		private Matrix4x4 CanvasToLocal;

		private Matrix4x4 MyToWorld;

		private Matrix4x4 MyToLocal;

		private List<UIVertex> m_tesselatedVerts;

		private List<UIVertex> m_curvedVerts;

		private List<UIVertex> m_vertsInQuads;

		private UIVertex m_ret;

		private UIVertex[] m_quad;

		private float[] m_weights;

		[SerializeField]
		[HideInInspector]
		private Vector3 savedPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 savedUp;

		[SerializeField]
		[HideInInspector]
		private Vector2 savedRectSize;

		[SerializeField]
		[HideInInspector]
		private Color savedColor;

		[SerializeField]
		[HideInInspector]
		private Vector4 savedTextUV0;

		[SerializeField]
		[HideInInspector]
		private float savedFill;

		private Vector4 _uv0;

		private Vector4 _uv1;

		private Vector3 _pos;

		private bool tesselationRequired
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

		public bool TesselationRequired
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

		public bool CurvingRequired
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
		protected override void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TesselationRequiredCallback()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FontTextureRebuiltCallback(Font fontie)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ModifyMesh(VertexHelper vh)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ModifyTMPMesh(ref List<UIVertex> vertexList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldModify()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CheckTextFontMaterial()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUISettings FindParentSettings(bool forceNew = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIVertex CurveVertex(UIVertex input, float cylinder_angle, float radius, Vector2 canvasSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TesselateGeometry(List<UIVertex> verts)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ModifyQuad(List<UIVertex> verts, int vertexIndex, Vector2 requiredSize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TrisToQuads(List<UIVertex> verts)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIVertex TesselateQuad(float x, float y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDirty()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUIVertexEffect()
		{

		}
	}
}
