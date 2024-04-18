using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;

namespace Zorro.Core
{
	public class EditorSingleton<T> : SerializedMonoBehaviour where T : EditorSingleton<T>
	{
		private static T _instance;

		private static bool m_shuttingDown;

		public static T Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnCreated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EditorSingleton()
		{

		}
	}
}
