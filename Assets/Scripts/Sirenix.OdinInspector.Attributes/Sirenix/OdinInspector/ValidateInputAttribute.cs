using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ValidateInputAttribute : Attribute
	{
		public string DefaultMessage;

		public string Condition;

		public InfoMessageType MessageType;

		public bool IncludeChildren;

		public bool ContinuousValidationCheck;

		[Obsolete("Use the Condition member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
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

		[Obsolete("Use the ContinuousValidationCheck member instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ContiniousValidationCheck
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
		public ValidateInputAttribute(string condition, string defaultMessage = null, InfoMessageType messageType = InfoMessageType.Error)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Rejecting invalid input is no longer supported. Use the other constructor instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ValidateInputAttribute(string condition, string message, InfoMessageType messageType, bool rejectedInvalidInput)
		{

		}
	}
}
