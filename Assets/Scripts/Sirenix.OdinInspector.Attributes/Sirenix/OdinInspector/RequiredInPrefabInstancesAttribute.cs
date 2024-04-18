using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use [RequiredIn(PrefabKind.PrefabInstance)] instead.", true)]
	public sealed class RequiredInPrefabInstancesAttribute : Attribute
	{
		public string ErrorMessage;

		public InfoMessageType MessageType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabInstancesAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabInstancesAttribute(string errorMessage, InfoMessageType messageType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabInstancesAttribute(string errorMessage)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredInPrefabInstancesAttribute(InfoMessageType messageType)
		{

		}
	}
}
