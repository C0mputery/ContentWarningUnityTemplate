using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	public class DetailedInfoBoxAttribute : Attribute
	{
		public string Message;

		public string Details;

		public InfoMessageType InfoMessageType;

		public string VisibleIf;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DetailedInfoBoxAttribute(string message, string details, InfoMessageType infoMessageType = InfoMessageType.Info, string visibleIf = null)
		{
			throw null;
		}
	}
}
