using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

[ModifierID("Free")]
public class FreeModifier : ProceduralImageModifier
{
	[SerializeField]
	private Vector4 radius;

	public Vector4 Radius
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
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnValidate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FreeModifier()
	{
		throw null;
	}
}
