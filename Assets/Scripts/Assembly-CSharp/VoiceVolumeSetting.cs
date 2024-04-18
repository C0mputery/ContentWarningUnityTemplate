using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine.Audio;
using Zorro.Settings;

public class VoiceVolumeSetting : FloatSetting, IExposedSetting
{
	public AudioMixerGroup mixerGroup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceVolumeSetting(AudioMixerGroup mixerGroup)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ApplyValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override float GetDefaultValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override float2 GetMinMaxValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SettingCategory GetSettingCategory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetDisplayName()
	{
		throw null;
	}
}
