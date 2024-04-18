using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PRaycastHit
	{
		public RaycastHit hit;

		public Ray ray;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PRaycastHit()
		{

		}
	}
}
