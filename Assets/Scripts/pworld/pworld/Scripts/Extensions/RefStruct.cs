using System.Runtime.CompilerServices;

namespace pworld.Scripts.Extensions
{
	public class RefStruct<T>
	{
		public T value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RefStruct(T t)
		{

		}
	}
}
