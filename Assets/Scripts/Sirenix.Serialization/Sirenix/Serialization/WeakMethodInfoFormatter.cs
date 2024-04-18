using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class WeakMethodInfoFormatter : MethodInfoFormatter<MethodInfo>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public WeakMethodInfoFormatter()
		{

		}
	}
}
