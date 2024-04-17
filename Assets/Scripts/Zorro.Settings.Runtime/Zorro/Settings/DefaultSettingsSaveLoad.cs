using System;
using System.Runtime.CompilerServices;

namespace Zorro.Settings
{
	public class DefaultSettingsSaveLoad : ISettingsSaveLoad
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryLoadInt(Type type, out int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveInt(Type type, int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteToDisk()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryLoadFloat(Type type, out float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveFloat(Type type, float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveString(Type type, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetString(Type type, out string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DefaultSettingsSaveLoad()
		{
			throw null;
		}
	}
}
