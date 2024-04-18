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

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabAssetsAttribute(string errorMessage, InfoMessageType messageType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabAssetsAttribute(string errorMessage)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabAssetsAttribute(InfoMessageType messageType)
		{

		}
	}
}
