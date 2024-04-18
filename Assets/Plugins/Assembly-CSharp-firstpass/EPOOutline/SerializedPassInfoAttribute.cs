using System;
using System.Runtime.CompilerServices;

namespace EPOOutline
{
	public class SerializedPassInfoAttribute : Attribute
	{
		public readonly string Title;

		public readonly string ShadersFolder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializedPassInfoAttribute(string title, string shadersFolder)
		{

		}
	}
}
