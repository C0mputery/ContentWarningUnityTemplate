using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class OdinRegisterAttributeAttribute : Attribute
	{
		public Type AttributeType;

		public string Categories;

		public string Description;

		public string DocumentationUrl;

		public bool IsEnterprise;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise, string url)
		{

		}
	}
}
