using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_Sound : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler
{
	public SFX_Instance hoverSound;

	public SFX_Instance clickSound;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnHover()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ButtonClicked()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerClick(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UI_Sound()
	{
		throw null;
	}
}
