using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.ProceduralImage
{
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Procedural Image")]
	public class ProceduralImage : Image
	{
		[SerializeField]
		private float borderWidth;

		private ProceduralImageModifier modifier;

		private static Material materialInstance;

		[SerializeField]
		private float falloffDistance;

		private static Material DefaultProceduralImageMaterial
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

		public float BorderWidth
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

		public float FalloffDistance
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

		protected ProceduralImageModifier Modifier
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

		public System.Type ModifierType
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

		public override Material material
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
		protected override void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnVerticesDirty()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void FixTexCoordsInCanvas()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void FixTexCoordsInCanvas(Canvas c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector4 FixRadius(Vector4 vec)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnTransformParentChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private ProceduralImageInfo CalculateInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float EncodeFloats_0_1_16_16(float a, float b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProceduralImage()
		{

		}
	}
}
