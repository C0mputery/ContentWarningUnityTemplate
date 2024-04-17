using System;
using System.Runtime.CompilerServices;

public class ModalOption
{
	public string Text;

	public Action OnClick;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModalOption(string text, Action onClick = null)
	{
		throw null;
	}
}
