using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class DateTimeOffsetFormatter : MinimalBaseFormatter<DateTimeOffset>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref DateTimeOffset value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref DateTimeOffset value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateTimeOffsetFormatter()
		{
			throw null;
		}
	}
}
