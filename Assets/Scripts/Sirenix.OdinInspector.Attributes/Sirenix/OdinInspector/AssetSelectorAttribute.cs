using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	public class AssetSelectorAttribute : Attribute
	{
		public bool IsUniqueList;

		public bool DrawDropdownForListElements;

		public bool DisableListAddButtonBehaviour;

		public bool ExcludeExistingValuesInList;

		public bool ExpandAllMenuItems;

		public bool FlattenTreeView;

		public int DropdownWidth;

		public int DropdownHeight;

		public string DropdownTitle;

		public string[] SearchInFolders;

		public string Filter;

		public string Paths
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
		public AssetSelectorAttribute()
		{

		}
	}
}
