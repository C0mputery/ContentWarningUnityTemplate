using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector.Internal;

namespace Sirenix.OdinInspector
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute
	{
		[Conditional("UNITY_EDITOR")]
		public class TabSubGroupAttribute : PropertyGroupAttribute
		{
			public TabGroupAttribute Tab;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TabSubGroupAttribute(TabGroupAttribute tab, string groupId, float order) : base(groupId, order)
			{
                throw null;
            }

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CombineValuesWith(PropertyGroupAttribute other)
			{
				throw null;
			}
		}

		public const string DEFAULT_NAME = "_DefaultTabGroup";

		public string TabName;

		public string TabId;

		public bool UseFixedHeight;

		public bool Paddingless;

		public bool HideTabGroupIfTabGroupOnlyHasOneTab;

		public string TextColor;

		public SdfIconType Icon;

		public TabLayouting TabLayouting;

		public List<TabGroupAttribute> Tabs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TabGroupAttribute(string tab, bool useFixedHeight = false, float order = 0f) : base(tab, order)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TabGroupAttribute(string group, string tab, bool useFixedHeight = false, float order = 0f) : base(group, order)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TabGroupAttribute(string group, string tab, SdfIconType icon, bool useFixedHeight = false, float order = 0f) : base(group, order)
		{
            throw null;
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CombineValuesWith(PropertyGroupAttribute other) 
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IList<PropertyGroupAttribute> ISubGroupProviderAttribute.GetSubGroupAttributes()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		string ISubGroupProviderAttribute.RepathMemberAttribute(PropertyGroupAttribute attr)
		{
			throw null;
		}
	}
}
