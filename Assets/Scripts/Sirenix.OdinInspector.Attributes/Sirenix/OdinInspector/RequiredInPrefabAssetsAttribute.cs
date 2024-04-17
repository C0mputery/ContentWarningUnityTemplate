using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Obsolete("Use [RequiredIn(PrefabKind.PrefabAsset)] instead.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class RequiredInPrefabAssetsAttribute : Attribute
	{
		public string ErrorMessage;

		public InfoMessageType MessageType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabAssetsAttribute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabAssetsAttribute(string errorMessage, InfoMessageType messageType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabAssetsAttribute(string errorMessage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabAssetsAttribute(InfoMessageType messageType)
		{
			throw null;
		}
	}
}
