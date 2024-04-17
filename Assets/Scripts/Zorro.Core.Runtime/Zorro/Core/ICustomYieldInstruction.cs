using System.Collections;

namespace Zorro.Core
{
	public interface ICustomYieldInstruction : IEnumerator
	{
		object IEnumerator.Current => null;

		bool KeepWaiting();

		bool IEnumerator.MoveNext()
		{
			return KeepWaiting();
		}

		void IEnumerator.Reset()
		{
		}
	}
}
