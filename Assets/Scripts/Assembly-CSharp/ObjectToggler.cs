using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
	public enum HideWhen
	{
		Local = 0,
		OtherClient = 1
	}

	public enum HideType
	{
		Disable = 0,
		DisableRenderers = 1,
		SwitchToShadowOnly = 2,
		SetLocalDontSeeLayer = 3
	}

	public HideWhen hideWhen;

	public HideType hideType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ObjectToggler()
	{

	}
}
