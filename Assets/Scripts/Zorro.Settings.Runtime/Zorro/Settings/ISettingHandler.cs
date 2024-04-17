namespace Zorro.Settings
{
	public interface ISettingHandler
	{
		void SaveSetting(Setting setting);

		T GetSetting<T>() where T : Setting;
	}
}
