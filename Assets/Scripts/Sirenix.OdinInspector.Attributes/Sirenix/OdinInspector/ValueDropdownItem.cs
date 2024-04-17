using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public struct ValueDropdownItem : IValueDropdownItem
	{
		public string Text;

		public object Value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueDropdownItem(string text, object value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		string IValueDropdownItem.GetText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		object IValueDropdownItem.GetValue()
		{
			throw null;
		}
	}
	public struct ValueDropdownItem<T> : IValueDropdownItem
	{
		public string Text;

		public T Value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValueDropdownItem(string text, T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		string IValueDropdownItem.GetText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		object IValueDropdownItem.GetValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}
	}
}
