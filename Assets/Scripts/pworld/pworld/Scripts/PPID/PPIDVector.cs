using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts.PPID
{
	[Serializable]
	public class PPIDVector
	{
		public float P;

		public float I;

		public float D;

		private PPID xPid;

		private PPID yPid;

		private PPID zPid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PPIDVector(float P, float I, float D)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PPIDVector()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValues(float p, float i, float d)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePIDValues()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetOutput(Vector3 currentError, float dt)
		{
			throw null;
		}
	}
}
