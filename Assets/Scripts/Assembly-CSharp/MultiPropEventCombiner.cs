using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "MultiPropEventCombiner", menuName = "MultiPropEventCombiner", order = 0)]
public class MultiPropEventCombiner : ContentCombiner
{
	public PropContent[] neededProps;

	public PropContent replacementProp;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Combine(List<ContentEventFrame> events)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MultiPropEventCombiner()
	{
		throw null;
	}
}
