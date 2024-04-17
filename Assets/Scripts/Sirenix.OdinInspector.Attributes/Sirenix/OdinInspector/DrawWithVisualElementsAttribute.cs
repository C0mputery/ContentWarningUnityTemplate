using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public class DrawWithVisualElementsAttribute : Attribute
	{
		public bool DrawCollectionWithImGUI;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DrawWithVisualElementsAttribute()
		{
			throw null;
		}
	}
}
