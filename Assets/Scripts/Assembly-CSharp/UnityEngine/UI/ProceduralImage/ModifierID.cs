using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.ProceduralImage
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ModifierID : Attribute
	{
		private string name;

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ModifierID(string name)
		{

		}
	}
}
