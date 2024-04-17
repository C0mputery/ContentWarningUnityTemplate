using System;

namespace Zorro.Settings
{
	public interface ISettingsSaveLoad
	{
		bool TryLoadInt(Type type, out int o);

		void SaveInt(Type type, int value);

		void WriteToDisk();

		bool TryLoadFloat(Type type, out float value);

		void SaveFloat(Type type, float value);

		void SaveString(Type type, string value);

		bool TryGetString(Type type, out string value);
	}
}
