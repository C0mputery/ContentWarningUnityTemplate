using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.PPhys;

namespace pworld.Scripts
{
	public class PCameraLook : MonoBehaviour
	{
		[SerializeReference]
		public ITimeSource timeSource;

		public bool usePInput;

		public float sensitity;

		public Vector2 minMaxPitch;

		public Vector2 minMaxYaw;

		public float pitch;

		public float yaw;

		private Transform pitchTrans;

		private Transform yawTrans;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Generate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClampPitchYaw()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PitchJawInput(Vector2 mouseDelta)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Rotate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PCameraLook()
		{

		}
	}
}
