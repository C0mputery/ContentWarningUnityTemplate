using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public static class SirenixAssetPaths
	{
		public const string DefaultSirenixPluginPath = "Assets/Plugins/Sirenix/";

		public const string SirenixAssetPathsSOGuid = "08379ccefc05200459f90a1c0711a340";

		public const string LookupAssetName = "OdinPathLookup.asset";

		public static readonly string OdinPath;

		public static readonly string SirenixAssetsPath;

		public static readonly string SirenixPluginPath;

		public static readonly string SirenixAssembliesPath;

		public static readonly string OdinResourcesPath;

		public static readonly string OdinEditorConfigsPath;

		public static readonly string OdinResourcesConfigsPath;

		public static readonly string OdinTempPath;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static SirenixAssetPaths()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string ToPathSafeString(string name, char replace = '_')
		{
			throw null;
		}
	}
}
