using System;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon
{
	internal class CustomType
	{
		public readonly byte Code;

		public readonly Type Type;

		public readonly SerializeMethod SerializeFunction;

		public readonly DeserializeMethod DeserializeFunction;

		public readonly SerializeStreamMethod SerializeStreamFunction;

		public readonly DeserializeStreamMethod DeserializeStreamFunction;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomType(Type type, byte code, SerializeMethod serializeFunction, DeserializeMethod deserializeFunction)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomType(Type type, byte code, SerializeStreamMethod serializeFunction, DeserializeStreamMethod deserializeFunction)
		{
			throw null;
		}
	}
}
