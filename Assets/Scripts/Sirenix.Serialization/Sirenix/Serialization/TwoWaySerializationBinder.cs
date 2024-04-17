using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public abstract class TwoWaySerializationBinder
	{
		public static readonly TwoWaySerializationBinder Default;

		public abstract string BindToName(Type type, DebugContext debugContext = null);

		public abstract Type BindToType(string typeName, DebugContext debugContext = null);

		public abstract bool ContainsType(string typeName);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TwoWaySerializationBinder()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static TwoWaySerializationBinder()
		{
			throw null;
		}
	}
}
