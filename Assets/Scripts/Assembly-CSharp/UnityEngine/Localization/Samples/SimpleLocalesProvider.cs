using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.Settings;

namespace UnityEngine.Localization.Samples
{
	public class SimpleLocalesProvider : ILocalesProvider
	{
		public List<Locale> Locales
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Locale GetLocale(LocaleIdentifier id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddLocale(Locale locale)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RemoveLocale(Locale locale)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SimpleLocalesProvider()
		{

		}
	}
}
