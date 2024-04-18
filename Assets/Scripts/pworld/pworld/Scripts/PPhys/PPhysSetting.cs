using System;
using System.Runtime.CompilerServices;

namespace pworld.Scripts.PPhys
{
	[Serializable]
	public class PPhysSetting
	{
		public float spring;

		public float damp;

		public float ropeLength;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PPhysSetting()
		{

		}
	}
}
