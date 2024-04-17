using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class TimeSpanFormatter : MinimalBaseFormatter<TimeSpan>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref TimeSpan value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref TimeSpan value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TimeSpanFormatter()
		{
			throw null;
		}
	}
}
