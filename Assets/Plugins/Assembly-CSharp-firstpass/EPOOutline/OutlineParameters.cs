using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	public class OutlineParameters
	{
		public readonly MeshPool MeshPool;

		public Camera Camera;

		public RenderTargetIdentifier Target;

		public RenderTargetIdentifier DepthTarget;

		public CommandBuffer Buffer;

		public DilateQuality DilateQuality;

		public int DilateIterations;

		public int BlurIterations;

		public Vector2 Scale;

		public Rect? CustomViewport;

		public long OutlineLayerMask;

		public int TargetWidth;

		public int TargetHeight;

		public float BlurShift;

		public float DilateShift;

		public bool UseHDR;

		public bool UseInfoBuffer;

		public bool IsEditorCamera;

		public BufferSizeMode PrimaryBufferSizeMode;

		public int PrimaryBufferSizeReference;

		public float PrimaryBufferScale;

		public StereoTargetEyeMask EyeMask;

		public int Antialiasing;

		public BlurType BlurType;

		public LayerMask Mask;

		public Mesh BlitMesh;

		public List<Outlinable> OutlinablesToRender;

		private bool isInitialized;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2Int MakeScaledVector(int x, int y)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckInitialization()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Prepare()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool CheckDiffers(Outlinable outlinable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool CheckIfNonOne(Outlinable.OutlineProperties parameters)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutlineParameters()
		{
			throw null;
		}
	}
}
