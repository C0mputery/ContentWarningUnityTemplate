using System.Runtime.CompilerServices;
using UnityEngine;

public class BatteryDisplay : MonoBehaviour
{
	public Material m_offMaterial;

	public Material m_greenMaterial;

	public Material m_yellowMaterial;

	public Material m_redMaterial;

	public Renderer[] m_renderer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCharge(float charge)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BatteryDisplay()
	{

	}
}
