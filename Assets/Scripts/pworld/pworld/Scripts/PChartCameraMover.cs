using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys;

namespace pworld.Scripts
{
	public class PChartCameraMover : MonoBehaviour
	{
		[SerializeReference]
		public ITimeSource timeSource;

		public float spring;

		public float realsedDamp;

		public float damp;

		public Vector2 Velocity;

		public Vector2 target;

		public bool isDragging;

		public Vector2 current;

		public Vector2 touchDown;

		public float dragSense;

		public bool moveCam;

		public float maxStepSize;

		[SerializeField]
		private float perspectiveDragSense;

		private readonly KeyCode dragButton;

		private bool applicationHadFocusLF;

		private Vector2 lastMousePos;

		public Vector2 Target
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

		public Vector2 Current
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

		private Camera Camera
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		private Vector2 MousePos
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		private Vector2 MouseMoveDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float DragSense
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Align()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GoTo(Vector2 positionxz)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PhysStep(float _dt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PChartCameraMover()
		{

		}
	}
}
