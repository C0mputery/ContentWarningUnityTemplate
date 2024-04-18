using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

[CreateAssetMenu(fileName = "CalibrationTextureHolder", menuName = "Zorro/CalibrationTextureHolder")]
public class CalibrationTextureHolder : SingletonAsset<CalibrationTextureHolder>
{
	public Texture2D[] calibrationTextures;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D GetTexture(BrightnessSetting brightnessSetting)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CalibrationTextureHolder()
	{

	}
}
