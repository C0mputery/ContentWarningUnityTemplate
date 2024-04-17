using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace EPOOutline
{
	[Serializable]
	public class OutlineTarget
	{
		public bool IsVisible;

		[SerializeField]
		public ColorMask CutoutMask;

		[SerializeField]
		private float edgeDilateAmount;

		[SerializeField]
		private float frontEdgeDilateAmount;

		[SerializeField]
		private float backEdgeDilateAmount;

		[SerializeField]
		[FormerlySerializedAs("Renderer")]
		public Renderer renderer;

		[SerializeField]
		public int SubmeshIndex;

		[SerializeField]
		public BoundsMode BoundsMode;

		[SerializeField]
		public Bounds Bounds;

		[SerializeField]
		[Range(0f, 1f)]
		public float CutoutThreshold;

		[SerializeField]
		public CullMode CullMode;

		[SerializeField]
		private string cutoutTextureName;

		[SerializeField]
		public DilateRenderMode DilateRenderingMode;

		[SerializeField]
		private int cutoutTextureIndex;

		private int? cutoutTextureId;

		public Renderer Renderer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool UsesCutout
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int CutoutTextureIndex
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

		public int ShiftedSubmeshIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int CutoutTextureId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string CutoutTextureName
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

		public float EdgeDilateAmount
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

		public float FrontEdgeDilateAmount
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

		public float BackEdgeDilateAmount
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
		public OutlineTarget()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutlineTarget(Renderer renderer, int submesh = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutlineTarget(Renderer renderer, string cutoutTextureName, float cutoutThreshold = 0.5f)
		{
			throw null;
		}
	}
}
