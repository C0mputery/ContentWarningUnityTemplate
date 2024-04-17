using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace CurvedUI
{
	[ExecuteInEditMode]
	public class CurvedUITMP : MonoBehaviour
	{
		private CurvedUIVertexEffect crvdVE;

		private TextMeshProUGUI tmpText;

		private CurvedUISettings mySettings;

		private List<UIVertex> m_UIVerts;

		private UIVertex m_tempVertex;

		private CurvedUITMPSubmesh m_tempSubMsh;

		private Vector2 savedSize;

		private Vector3 savedUp;

		private Vector3 savedPos;

		private Vector3 savedLocalScale;

		private Vector3 savedGlobalScale;

		private List<CurvedUITMPSubmesh> subMeshes;

		public bool Dirty;

		private bool curvingRequired;

		private bool tesselationRequired;

		private bool quitting;

		private Vector3[] vertices;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateUIVertexList(Mesh mesh)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetUIVertexFromMesh(ref UIVertex vert, int i)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FillMeshWithUIVertexList(Mesh mesh, List<UIVertex> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FindTMP()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FindSubmeshes()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldTesselate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TMPTextChangedCallback(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TesselationRequiredCallback()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUITMP()
		{
			throw null;
		}
	}
}
