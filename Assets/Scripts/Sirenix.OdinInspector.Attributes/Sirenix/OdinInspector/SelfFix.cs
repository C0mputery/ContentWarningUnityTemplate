using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public struct SelfFix
	{
		public string Title;

		public Delegate Action;

		public bool OfferInInspector;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelfFix(string name, Action action, bool offerInInspector)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelfFix(string name, Delegate action, bool offerInInspector)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SelfFix Create(Action action, bool offerInInspector = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SelfFix Create(string title, Action action, bool offerInInspector = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SelfFix Create<T>(Action<T> action, bool offerInInspector = true) where T : new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static SelfFix Create<T>(string title, Action<T> action, bool offerInInspector = true) where T : new()
		{
			throw null;
		}
	}
}
