using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Photon.Pun.UtilityScripts
{
	public class TabViewManager : MonoBehaviour
	{
		[Serializable]
		public class TabChangeEvent : UnityEvent<string>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public TabChangeEvent()
			{
				throw null;
			}
		}

		[Serializable]
		public class Tab
		{
			public string ID;

			public Toggle Toggle;

			public RectTransform View;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Tab()
			{
				throw null;
			}
		}

		public ToggleGroup ToggleGroup;

		public Tab[] Tabs;

		public TabChangeEvent OnTabChanged;

		protected Tab CurrentTab;

		private Dictionary<Toggle, Tab> Tab_lut;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectTab(string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnTabSelected(Tab tab)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TabViewManager()
		{
			throw null;
		}
	}
}
