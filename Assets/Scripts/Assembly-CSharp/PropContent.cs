using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "PropContent", menuName = "ContentEvent/PropContent", order = 0)]
public class PropContent : ScriptableObject
{
	[HideInInspector]
	public bool isArtifact;

	public float contentValue;

	public ushort id;

	public string[] comments;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropContentEvent GetContentEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PropContent()
	{
		throw null;
	}
}
