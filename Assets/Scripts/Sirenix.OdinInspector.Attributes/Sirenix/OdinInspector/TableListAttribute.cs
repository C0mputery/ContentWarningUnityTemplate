using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class TableListAttribute : Attribute
	{
		public int NumberOfItemsPerPage;

		public bool IsReadOnly;

		public int DefaultMinColumnWidth;

		public bool ShowIndexLabels;

		public bool DrawScrollView;

		public int MinScrollViewHeight;

		public int MaxScrollViewHeight;

		public bool AlwaysExpanded;

		public bool HideToolbar;

		public int CellPadding;

		[SerializeField]
		[HideInInspector]
		private bool showPagingHasValue;

		[SerializeField]
		[HideInInspector]
		private bool showPaging;

		public bool ShowPaging
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

		public bool ShowPagingHasValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int ScrollViewHeight
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
		public TableListAttribute()
		{
			throw null;
		}
	}
}
