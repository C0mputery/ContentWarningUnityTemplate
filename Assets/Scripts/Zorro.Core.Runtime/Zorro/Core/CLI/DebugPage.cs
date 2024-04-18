using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

namespace Zorro.Core.CLI
{
	public abstract class DebugPage : VisualElement
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DebugPage()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Removed(DetachFromPanelEvent e)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update()
		{
			throw null;
		}
	}
}
