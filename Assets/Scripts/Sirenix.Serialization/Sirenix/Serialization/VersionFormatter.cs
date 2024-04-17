using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class VersionFormatter : MinimalBaseFormatter<Version>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Version GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Version value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Version value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VersionFormatter()
		{
			throw null;
		}
	}
}
