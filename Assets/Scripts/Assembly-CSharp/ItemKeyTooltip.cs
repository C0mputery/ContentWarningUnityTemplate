using System;
using System.Runtime.CompilerServices;

[Serializable]
public class ItemKeyTooltip : IHaveUIData
{
	public string m_key;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemKeyTooltip(string key)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetString()
	{
		throw null;
	}
}
