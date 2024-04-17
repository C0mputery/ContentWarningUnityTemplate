namespace pworld.Scripts.PPhys
{
	public interface ITimeSource
	{
		float TimeScale { get; set; }

		float DeltaTime { get; }

		void GoToPreviousTimeScale();
	}
}
