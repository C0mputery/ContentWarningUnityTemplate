using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Localization.Samples
{
	public class LanguageSelectionMenuIMGUI : MonoBehaviour
	{
		public Rect windowRect;

		public Color selectColor;

		public Color defaultColor;

		private Vector2 m_ScrollPos;

		private Dictionary<Locale, string> m_Labels;

		[Tooltip("Use the current active settings if possible or create a new one for the example")]
		public bool useActiveLocalizationSettings;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void OnSelectedLocaleChanged(Locale newLocale)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GetLocaleLabel(Locale locale)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawWindowContents(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LanguageSelectionMenuIMGUI()
		{
			throw null;
		}
	}
}
