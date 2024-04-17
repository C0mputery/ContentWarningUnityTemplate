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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(string unit)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(Units @base, Units display)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(Units @base, string display)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(string @base, Units display)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UnitAttribute(string @base, string display)
		{
			throw null;
		}
	}
}
