using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public static class FormatterEmitter
	{
		[EmittedFormatter]
		public abstract class AOTEmittedFormatter<T> : EasyBaseFormatter<T>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected AOTEmittedFormatter()
			{
				throw null;
			}
		}

		public abstract class EmptyAOTEmittedFormatter<T> : AOTEmittedFormatter<T>
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ReadDataEntry(ref T value, string entryName, EntryType entryType, IDataReader reader)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void WriteDataEntries(ref T value, IDataWriter writer)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected EmptyAOTEmittedFormatter()
			{
				throw null;
			}
		}

		private static int helperFormatterNameId;

		public const string PRE_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.AOTGenerated";

		public const string RUNTIME_EMITTED_ASSEMBLY_NAME = "Sirenix.Serialization.RuntimeEmitted";

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IFormatter GetEmittedFormatter(Type type, ISerializationPolicy policy)
		{
			throw null;
		}
	}
}
