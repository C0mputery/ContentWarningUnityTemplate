using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Photon.Chat.Demo
{
	public class ChannelSelector : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public string Channel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetChannel(string channel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChannelSelector()
		{

		}
	}
}
