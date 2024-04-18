using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI.ProceduralImage;

[ModifierID("Uniform")]
public class UniformModifier : ProceduralImageModifier
{
	[SerializeField]
	private float radius;

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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UniformModifier()
	{

	}
}
