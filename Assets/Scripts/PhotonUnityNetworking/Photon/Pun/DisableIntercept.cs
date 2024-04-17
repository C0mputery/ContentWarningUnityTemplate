using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public abstract class DisableIntercept : MonoBehaviour
	{
		public abstract bool CanIntercept();

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected DisableIntercept()
		{
			throw null;
		}
	}
}
