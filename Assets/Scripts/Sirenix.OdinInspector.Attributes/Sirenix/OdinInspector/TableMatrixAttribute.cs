using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	[Conditional("UNITY_EDITOR")]
	public class TableMatrixAttribute : Attribute
	{
		public bool IsReadOnly;

		public bool ResizableColumns;

		public string VerticalTitle;

		public string HorizontalTitle;

		public string DrawElementMethod;

		public int RowHeight;

		public bool SquareCells;

		public bool HideColumnIndices;

		public bool HideRowIndices;

		public bool RespectIndentLevel;

		public bool Transpose;

		public string Labels;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TableMatrixAttribute()
		{

		}
	}
}
