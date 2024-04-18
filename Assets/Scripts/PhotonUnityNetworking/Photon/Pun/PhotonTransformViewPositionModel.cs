using System;
using System.Runtime.CompilerServices;

namespace Photon.Pun
{
	[Serializable]
	public class PhotonTransformViewPositionModel
	{
		public enum InterpolateOptions
		{
			Disabled = 0,
			FixedSpeed = 1,
			EstimatedSpeed = 2,
			SynchronizeValues = 3,
			Lerp = 4
		}

		public enum ExtrapolateOptions
		{
			Disabled = 0,
			SynchronizeValues = 1,
			EstimateSpeedAndTurn = 2,
			FixedSpeed = 3
		}

		public bool SynchronizeEnabled;

		public bool TeleportEnabled;

		public float TeleportIfDistanceGreaterThan;

		public InterpolateOptions InterpolateOption;

		public float InterpolateMoveTowardsSpeed;

		public float InterpolateLerpSpeed;

		public ExtrapolateOptions ExtrapolateOption;

		public float ExtrapolateSpeed;

		public bool ExtrapolateIncludingRoundTripTime;

		public int ExtrapolateNumberOfStoredPositions;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransformViewPositionModel()
		{

		}
	}
}
