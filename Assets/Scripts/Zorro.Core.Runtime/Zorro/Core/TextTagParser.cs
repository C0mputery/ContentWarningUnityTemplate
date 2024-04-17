using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public class TextTagParser<T> where T : TextTag
	{
		public class RegisteredTag
		{
			public Type type;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public RegisteredTag()
			{
				throw null;
			}
		}

		private static char tagStart;

		private static char tagEnd;

		private static char tagEndIndicator;

		private Dictionary<string, RegisteredTag> m_registeredTags;

		private List<(string, T)> m_openTags;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TextTagParser()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ParseText(string text, out List<T> tags)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private T CloseTag(string tagName, string textBefore)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TextTagParser()
		{
			throw null;
		}
	}
}
