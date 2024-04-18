using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public class Singleton<T> : MonoBehaviour where T : Singleton<T>
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
		protected virtual void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnCreated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T FindInstance()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ClearInstance()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Singleton()
		{

		}
	}
}
