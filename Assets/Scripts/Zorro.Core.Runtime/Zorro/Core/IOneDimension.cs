namespace Zorro.Core
{
	public interface IOneDimension
	{
		float Velocity { get; }

		float Current { get; }

		void SetCurrent(float current);

		void SetVelocity(float velocity);

		void AddForce(float force);
	}
}
