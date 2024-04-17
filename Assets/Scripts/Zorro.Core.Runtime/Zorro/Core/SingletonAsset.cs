using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;

namespace Zorro.Core
{
	public abstract class SingletonAsset<T> : SerializedScriptableObject where T : SingletonAsset<T>
	{
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
		public virtual void OnLoaded()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected SingletonAsset()
		{
			throw null;
		}
	}
}
