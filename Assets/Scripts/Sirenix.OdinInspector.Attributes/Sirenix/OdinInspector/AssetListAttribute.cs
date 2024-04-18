using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class AssetListAttribute : Attribute
	{
		public bool AutoPopulate;

		public string Tags;

		public string LayerNames;

		public string AssetNamePrefix;

		public string Path;

		public string CustomFilterMethod;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AssetListAttribute()
		{

		}
	}
}
