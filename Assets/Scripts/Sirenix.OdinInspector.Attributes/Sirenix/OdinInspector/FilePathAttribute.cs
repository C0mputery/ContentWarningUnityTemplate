using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class FilePathAttribute : Attribute
	{
		public bool AbsolutePath;

		public string Extensions;

		public string ParentFolder;

		[Obsolete("Use RequireExistingPath instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool RequireValidPath;

		public bool RequireExistingPath;

		public bool UseBackslashes;

		public bool IncludeFileExtension;

		[Obsolete("Add a ReadOnly attribute to the property instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool ReadOnly
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FilePathAttribute()
		{

		}
	}
}
