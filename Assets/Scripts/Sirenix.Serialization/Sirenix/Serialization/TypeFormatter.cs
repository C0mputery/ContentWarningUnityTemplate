using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public sealed class TypeFormatter : MinimalBaseFormatter<Type>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Read(ref Type value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Write(ref Type value, IDataWriter writer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Type GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TypeFormatter()
		{

		}
	}
}
