using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Photon.Pun.UtilityScripts
{
	public class OnClickInstantiate : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public enum InstantiateOption
		{
			Mine = 0,
			Scene = 1
		}

		public PointerEventData.InputButton Button;

		public KeyCode ModifierKey;

		public GameObject Prefab;

		[SerializeField]
		private InstantiateOption InstantiateType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OnClickInstantiate()
		{

		}
	}
}
