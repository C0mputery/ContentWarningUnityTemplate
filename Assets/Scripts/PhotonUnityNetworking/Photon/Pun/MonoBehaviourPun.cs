using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Pun
{
	public class MonoBehaviourPun : MonoBehaviour
	{
		private PhotonView pvCache;

		public PhotonView photonView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonoBehaviourPun()
		{

		}
	}
}
