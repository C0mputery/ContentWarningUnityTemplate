using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public sealed class DictionaryDrawerSettings : Attribute
	{
		public string KeyLabel;

		public string ValueLabel;

		public DictionaryDisplayOptions DisplayMode;

		public bool IsReadOnly;

		public float KeyColumnWidth;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DictionaryDrawerSettings()
		{

		}
	}
}
