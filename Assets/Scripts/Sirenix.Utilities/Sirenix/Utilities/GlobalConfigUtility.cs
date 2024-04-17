using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Utilities
{
	public static class GlobalConfigUtility<T> where T : ScriptableObject
	{
		private static T instance;

		public static bool HasInstanceLoaded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T GetInstance(string defaultAssetFolderPath, string defaultFileNameWithoutExtension = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void LoadInstanceIfAssetExists(string assetPath, string defaultFileNameWithoutExtension = null)
		{
			throw null;
		}
	}
}
