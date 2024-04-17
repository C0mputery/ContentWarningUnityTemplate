using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using pworld.Scripts.PPhys;

namespace pworld.Scripts.PUI
{
	public class PUIOnHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		public float hoverScaleMul;

		private RectTransform rectT_g;

		[CanBeNull]
		private PPhysScaleLocal scale_g;

		private bool selected;

		private Vector3 startScale;

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
		public void OnDeselect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MakeBig()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MakeSmall()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PUIOnHover()
		{
			throw null;
		}
	}
}
