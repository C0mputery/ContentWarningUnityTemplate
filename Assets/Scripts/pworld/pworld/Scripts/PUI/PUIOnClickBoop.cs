using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using pworld.Scripts.PPhys;

namespace pworld.Scripts.PUI
{
	public class PUIOnClickBoop : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public float boopForce;

		private RectTransform rectT_g;

		private PPhysSpringBase scaler_g;

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
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PUIOnClickBoop()
		{

		}
	}
}
