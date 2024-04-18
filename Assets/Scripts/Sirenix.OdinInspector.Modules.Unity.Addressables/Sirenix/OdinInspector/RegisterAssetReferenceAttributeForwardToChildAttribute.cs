using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class RegisterAssetReferenceAttributeForwardToChildAttribute : Attribute
	{
		public readonly Type AttributeType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegisterAssetReferenceAttributeForwardToChildAttribute(Type attributeType)
		{

		}
	}
}
