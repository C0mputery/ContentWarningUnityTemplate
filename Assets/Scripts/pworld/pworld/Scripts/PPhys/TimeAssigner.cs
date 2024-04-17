using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPhys
{
	public class TimeAssigner : MonoBehaviour
	{
		[SerializeReference]
		public ITimeSource timeSource;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssignTimeSource(ITimeSource source)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeAssigner()
		{
			throw null;
		}
	}
}
