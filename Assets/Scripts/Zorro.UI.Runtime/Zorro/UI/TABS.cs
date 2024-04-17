using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.UI
{
	public abstract class TABS<ButtonType> : MonoBehaviour, ITABS where ButtonType : TAB_Button
	{
		public ButtonType selectedButton;

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select(ButtonType button)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deslect(ButtonType button)
		{
			throw null;
		}

		public abstract void OnSelected(ButtonType button);

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectGeneric(TAB_Button button)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TABS()
		{
			throw null;
		}
	}
}
