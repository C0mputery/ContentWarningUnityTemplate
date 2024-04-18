using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
	public class SirenixBuildVersionAttribute : Attribute
	{
		public string Version
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
		public SirenixBuildVersionAttribute(string version)
		{

		}
	}
}
