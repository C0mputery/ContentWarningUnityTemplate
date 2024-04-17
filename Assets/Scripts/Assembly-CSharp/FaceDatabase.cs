using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(menuName = "Database/FaceDatabase", fileName = "FaceDatabase")]
public class FaceDatabase : SingletonAsset<FaceDatabase>
{
	public Color[] FaceColors;

	public string[] Faces;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte GetRandomFaceIndex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte GetRandomColorIndex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetFace(byte index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color GetColor(byte index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FaceDatabase()
	{
		throw null;
	}
}
