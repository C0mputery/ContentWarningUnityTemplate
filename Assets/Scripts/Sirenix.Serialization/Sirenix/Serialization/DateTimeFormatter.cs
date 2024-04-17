using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class DateTimeFormatter : MinimalBaseFormatter<DateTime>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref DateTime value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref DateTime value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DateTimeFormatter()
		{
			throw null;
		}
	}
}
