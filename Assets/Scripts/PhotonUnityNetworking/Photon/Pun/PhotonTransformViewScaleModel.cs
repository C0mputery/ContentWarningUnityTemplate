using System;
using System.Runtime.CompilerServices;

namespace Photon.Pun
{
	[Serializable]
	public class PhotonTransformViewScaleModel
	{
		public enum InterpolateOptions
		{
			Disabled = 0,
			MoveTowards = 1,
			Lerp = 2
		}

		public bool SynchronizeEnabled;

		public InterpolateOptions InterpolateOption;

		public float InterpolateMoveTowardsSpeed;

		public float InterpolateLerpSpeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonTransformViewScaleModel()
		{

		}
	}
}
