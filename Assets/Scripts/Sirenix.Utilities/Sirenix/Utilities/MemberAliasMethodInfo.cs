using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public sealed class MemberAliasMethodInfo : MethodInfo
	{
		private const string FAKE_NAME_SEPARATOR_STRING = "+";

		private MethodInfo aliasedMethod;

		private string mangledName;

		public MethodInfo AliasedMethod
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override ICustomAttributeProvider ReturnTypeCustomAttributes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override RuntimeMethodHandle MethodHandle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override MethodAttributes Attributes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override Type ReturnType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override Type DeclaringType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override Type ReflectedType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MemberAliasMethodInfo(MethodInfo method, string namePrefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MemberAliasMethodInfo(MethodInfo method, string namePrefix, string separatorString)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override MethodInfo GetBaseDefinition()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ParameterInfo[] GetParameters()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw null;
		}
	}
}
