using System.Runtime.CompilerServices;
using UnityEngine;

namespace CurvedUI
{
	public class CurvedUIHandSwitcher : MonoBehaviour
	{
		[SerializeField]
		private GameObject LaserBeam;

		[SerializeField]
		[Tooltip("If true, when player clicks the trigger on the other hand, we'll instantly set it as UI controlling hand and move the pointer to it.")]
		private bool autoSwitchHands;

		[Header("Optional")]
		[SerializeField]
		[Tooltip("If set, pointer will be placed as a child of this transform, instead of the current VR SDKs Camera Rig.")]
		private Transform leftHandOverride;

		[SerializeField]
		[Tooltip("If set, pointer will be placed as a child of this transform, instead of the current VR SDKs Camera Rig.")]
		private Transform rightHandOverride;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SwitchHandTo(CurvedUIInputModule.Hand newHand)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CurvedUIHandSwitcher()
		{
			throw null;
		}
	}
}
