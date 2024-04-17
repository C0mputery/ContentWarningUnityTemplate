using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public class CoreGlobalDependencies : SingletonAsset<CoreGlobalDependencies>
	{
		public GameObject ConsolePrefab;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CoreGlobalDependencies()
		{
			throw null;
		}
	}
}
