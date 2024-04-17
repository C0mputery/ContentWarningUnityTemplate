using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Pun
{
	public class PhotonStreamQueue
	{
		private int m_SampleRate;

		private int m_SampleCount;

		private int m_ObjectsPerSample;

		private float m_LastSampleTime;

		private int m_LastFrameCount;

		private int m_NextObjectIndex;

		private List<object> m_Objects;

		private bool m_IsWriting;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonStreamQueue(int sampleRate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BeginWritePackage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendNext(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasQueuedObjects()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ReceiveNext()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(PhotonStream stream)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(PhotonStream stream)
		{
			throw null;
		}
	}
}
