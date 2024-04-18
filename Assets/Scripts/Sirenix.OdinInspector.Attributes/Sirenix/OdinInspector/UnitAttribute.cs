using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public class UnitAttribute : Attribute
	{
		public Units Base;

		public Units Display;

		public string BaseName;

		public string DisplayName;

		public bool DisplayAsString;

		public bool ForceDisplayUnit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(Units unit)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(string unit)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(Units @base, Units display)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(Units @base, string display)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(string @base, Units display)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(string @base, string display)
		{

		}
	}
}
