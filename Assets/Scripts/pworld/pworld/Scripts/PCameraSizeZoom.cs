using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys;

namespace pworld.Scripts
{
	public class PCameraSizeZoom : MonoBehaviour
	{
		public float velocity;

		public float target;

		public float current;

		public float spring;

		public float damp;

		public float maxStepSize;

		public float stepSize;

		public Vector2 minMaxSize;

		public Vector2 minMaxFOV;

		public float mouseDiffMullInPerspective;

		private Camera cam;

		private PChartCameraMover mover;

		[SerializeReference]
		public ITimeSource timeSouce;

		public Vector2 MinMaxZoom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float Zoom
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

		public Vector3 MousePosInFrustum
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhysStep(float dt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PCameraSizeZoom()
		{

		}
	}
}
