using System.Runtime.CompilerServices;

namespace pworld.Scripts.Extensions
{
	public class Nullable<T>
	{
		private bool isNull;

		private T t;

		public bool HasValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public T Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FakeNullIt()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Nullable()
		{
			throw null;
		}
	}
}
