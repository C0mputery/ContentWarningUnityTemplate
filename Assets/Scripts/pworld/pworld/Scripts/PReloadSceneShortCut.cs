using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PReloadSceneShortCut : MonoBehaviour
	{
		[SerializeField]
		private KeyCode tappedKey;

		[SerializeField]
		private KeyCode heldKey;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReloadScene()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PReloadSceneShortCut()
		{

		}
	}
}
