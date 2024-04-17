using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public class RetrievableResourceSingleton<T> : MonoBehaviour where T : RetrievableResourceSingleton<T>
	{
		private static bool m_shuttingDown;

		private static T _instance;

		public static T Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnCreated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static T CreateInstance()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RetrievableResourceSingleton()
		{
			throw null;
		}
	}
}
