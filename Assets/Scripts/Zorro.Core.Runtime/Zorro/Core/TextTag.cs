using System.Runtime.CompilerServices;

namespace Zorro.Core
{
	public abstract class TextTag
	{
		private TextTag m_otherTag;

		public string TextBeforeTag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public string LastText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public bool IsOpeningTag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup(string textBeforeTag)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup(string textBeforeTag, TextTag otherTag)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ParseParameter(string param)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T GetOtherTag<T>() where T : TextTag
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLastText(string lastText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TextTag()
		{
			throw null;
		}
	}
}
