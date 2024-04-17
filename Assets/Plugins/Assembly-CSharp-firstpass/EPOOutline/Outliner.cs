using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

namespace EPOOutline
{
	[ExecuteAlways]
	[RequireComponent(typeof(Camera))]
	public class Outliner : MonoBehaviour
	{
		private static List<Outlinable> temporaryOutlinables;

		private OutlineParameters parameters;

		private Camera targetCamera;

		[SerializeField]
		private RenderStage stage;

		[SerializeField]
		private OutlineRenderingStrategy renderingStrategy;

		[SerializeField]
		private RenderingMode renderingMode;

		[SerializeField]
		private long outlineLayerMask;

		[SerializeField]
		private BufferSizeMode primaryBufferSizeMode;

		[SerializeField]
		[Range(0.15f, 1f)]
		private float primaryRendererScale;

		[SerializeField]
		private int primarySizeReference;

		[SerializeField]
		[Range(0f, 2f)]
		private float blurShift;

		[SerializeField]
		[Range(0f, 2f)]
		private float dilateShift;

		[SerializeField]
		[FormerlySerializedAs("dilateIterrations")]
		private int dilateIterations;

		[SerializeField]
		private DilateQuality dilateQuality;

		[SerializeField]
		[FormerlySerializedAs("blurIterrations")]
		private int blurIterations;

		[SerializeField]
		private BlurType blurType;

		[Obsolete]
		public float InfoRendererScale
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

		public int PrimarySizeReference
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

		public BufferSizeMode PrimaryBufferSizeMode
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

		private CameraEvent Event
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public OutlineRenderingStrategy RenderingStrategy
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

		public RenderStage RenderStage
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

		public DilateQuality DilateQuality
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

		private RenderingMode RenderingMode
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

		public float BlurShift
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

		public float DilateShift
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

		public long OutlineLayerMask
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

		public float PrimaryRendererScale
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

		[Obsolete("Fixed incorrect spelling. Use BlurIterations instead")]
		public int BlurIterrations
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

		public int BlurIterations
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

		public BlurType BlurType
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

		[Obsolete("Fixed incorrect spelling. Use DilateIterations instead")]
		public int DilateIterration
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

		public int DilateIterations
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
		private void OnValidate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateBuffer(Camera targetCamera, CommandBuffer buffer, bool removeOnly)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnPreRender()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetupOutline(Camera cameraToUse, OutlineParameters parametersToUse, bool isEditor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSharedParameters(OutlineParameters parameters, Camera camera, bool editorCamera)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateParameters(OutlineParameters parameters, Camera camera, bool editorCamera)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Outliner()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Outliner()
		{
			throw null;
		}
	}
}
