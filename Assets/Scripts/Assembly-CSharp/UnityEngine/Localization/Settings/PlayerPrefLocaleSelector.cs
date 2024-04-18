using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class PlayerPrefLocaleSelector : IStartupLocaleSelector, IInitialize
	{
		[SerializeField]
		private string m_PlayerPreferenceKey;

		public string PlayerPreferenceKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PostInitialization(LocalizationSettings settings)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Locale GetStartupLocale(ILocalesProvider availableLocales)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerPrefLocaleSelector()
		{

		}
	}
}
