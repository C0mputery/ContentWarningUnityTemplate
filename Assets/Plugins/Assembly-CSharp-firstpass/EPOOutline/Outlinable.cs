using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline
{
	[ExecuteAlways]
	public class Outlinable : MonoBehaviour
	{
		[Serializable]
		public class OutlineProperties
		{
			[SerializeField]
			private bool enabled;

			[SerializeField]
			private Color color;

			[SerializeField]
			[Range(0f, 1f)]
			private float dilateShift;

			[SerializeField]
			[Range(0f, 1f)]
			private float blurShift;

			[SerializeField]
			[SerializedPassInfo("Fill style", "Hidden/EPO/Fill/")]
			private SerializedPass fillPass;

			public bool Enabled
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

			public Color Color
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

			public SerializedPass FillPass
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public OutlineProperties()
			{
				throw null;
			}
		}

		private static List<TargetStateListener> tempListeners;

		private static HashSet<Outlinable> outlinables;

		[SerializeField]
		private ComplexMaskingMode complexMaskingMode;

		[SerializeField]
		private OutlinableDrawingMode drawingMode;

		[SerializeField]
		private int outlineLayer;

		[SerializeField]
		private List<OutlineTarget> outlineTargets;

		[SerializeField]
		private RenderStyle renderStyle;

		[SerializeField]
		private OutlineProperties outlineParameters;

		[SerializeField]
		private OutlineProperties backParameters;

		[SerializeField]
		private OutlineProperties frontParameters;

		private bool shouldValidateTargets;

		public RenderStyle RenderStyle
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

		public ComplexMaskingMode ComplexMaskingMode
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

		public bool ComplexMaskingEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public OutlinableDrawingMode DrawingMode
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

		public int OutlineLayer
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

		public IReadOnlyList<OutlineTarget> OutlineTargets
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public OutlineProperties OutlineParameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public OutlineProperties BackParameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool NeedFillMask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public OutlineProperties FrontParameters
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsObstacle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public OutlineTarget this[int index]
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
		public bool TryAddTarget(OutlineTarget target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveTarget(OutlineTarget target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SubscribeToVisibilityChange(GameObject go)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateVisibility()
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
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ValidateTargets()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void GetAllActiveOutlinables(Camera camera, List<Outlinable> outlinablesList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetSubmeshCount(Renderer renderer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAllChildRenderersToRenderingList(RenderersAddingMode renderersAddingMode = RenderersAddingMode.All, bool includeInactive = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MatchingMode(Renderer renderer, RenderersAddingMode mode)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Outlinable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static Outlinable()
		{
			throw null;
		}
	}
}
