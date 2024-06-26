using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class RequiredAttribute : Attribute
	{
		public string ErrorMessage;

		public InfoMessageType MessageType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredAttribute()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredAttribute(string errorMessage, InfoMessageType messageType)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredAttribute(string errorMessage)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequiredAttribute(InfoMessageType messageType)
		{

		}
	}
}
