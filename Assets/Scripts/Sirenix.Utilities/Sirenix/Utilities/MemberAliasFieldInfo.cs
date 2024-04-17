using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public sealed class MemberAliasFieldInfo : FieldInfo
	{
		private const string FAKE_NAME_SEPARATOR_STRING = "+";

		private FieldInfo aliasedField;

		private string mangledName;

		public FieldInfo AliasedField
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

		public override Type FieldType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override RuntimeFieldHandle FieldHandle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override FieldAttributes Attributes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MemberAliasFieldInfo(FieldInfo field, string namePrefix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MemberAliasFieldInfo(FieldInfo field, string namePrefix, string separatorString)
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
		public override object GetValue(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			throw null;
		}
	}
}
