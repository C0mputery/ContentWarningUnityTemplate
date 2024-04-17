using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization.Utilities
{
	internal sealed class MemberAliasPropertyInfo : PropertyInfo
	{
		private const string FakeNameSeparatorString = "+";

		private PropertyInfo aliasedProperty;

		private string mangledName;

		public PropertyInfo AliasedProperty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override Module Module
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override int MetadataToken
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

		public override Type DeclaringType
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

		public override Type PropertyType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override PropertyAttributes Attributes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool CanRead
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override bool CanWrite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MemberAliasPropertyInfo(PropertyInfo prop, string namePrefix, string separatorString)
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
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override MethodInfo[] GetAccessors(bool nonPublic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ParameterInfo[] GetIndexParameters()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			throw null;
		}
	}
}
