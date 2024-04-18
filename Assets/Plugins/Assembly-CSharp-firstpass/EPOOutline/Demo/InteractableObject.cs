using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EPOOutline.Demo
{
	public class InteractableObject : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		[SerializeField]
		private AudioClip interactionSound;

		[SerializeField]
		private bool affectOutlinable;

		private Outlinable outlinable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
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
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InteractableObject()
		{

		}
	}
}
