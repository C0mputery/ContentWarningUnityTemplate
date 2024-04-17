using System.Reflection;
using System.Runtime.CompilerServices;
using Sirenix.Serialization;
using UnityEngine.Localization;

namespace Sirenix.OdinInspector.Modules.Localization
{
	public class LocalizedStringFormatter : ReflectionOrEmittedBaseFormatter<LocalizedString>
	{
		private static readonly FieldInfo m_LocalVariables_Field;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static LocalizedStringFormatter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override LocalizedString GetUninitializedObject()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DeserializeImplementation(ref LocalizedString value, IDataReader reader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocalizedStringFormatter()
		{
			throw null;
		}
	}
}
