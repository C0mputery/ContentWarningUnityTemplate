using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

[ModifierID("Only One Edge")]
public class OnlyOneEdgeModifier : ProceduralImageModifier
{
	public enum ProceduralImageEdge
	{
		Top = 0,
		Bottom = 1,
		Left = 2,
		Right = 3
	}

	[SerializeField]
	private float radius;

	[SerializeField]
	private ProceduralImageEdge side;

	public float Radius
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

	public ProceduralImageEdge Side
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
	public OnlyOneEdgeModifier()
	{
		throw null;
	}
}
