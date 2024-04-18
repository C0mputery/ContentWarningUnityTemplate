using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	public class RegisterFormatterAttribute : Attribute
	{
		public Type FormatterType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public Type WeakFallback
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public int Priority
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegisterFormatterAttribute(Type formatterType, int priority = 0)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegisterFormatterAttribute(Type formatterType, Type weakFallback, int priority = 0)
		{

		}
	}
}
