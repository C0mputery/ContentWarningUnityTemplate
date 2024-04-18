using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CurvedUI
{
	[ExecuteInEditMode]
	public class CurvedUITMPSubmesh : MonoBehaviour
	{
		private VertexHelper _vh;

		private Mesh _straightMesh;

		private Mesh _curvedMesh;

		private CurvedUIVertexEffect _crvdVe;

		private TMP_SubMeshUI _tmPsub;

		private TextMeshProUGUI _tmPtext;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSubmesh(bool tesselate, bool curve)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUITMPSubmesh()
		{

		}
	}
}
