using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Photon.Realtime;
using UnityEngine;

namespace Photon.Pun
{
	public class PhotonStream
	{
		private List<object> writeData;

		private object[] readData;

		private int currentItem;

		public bool IsWriting
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public bool IsReading
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PhotonStream(bool write, object[] incomingData)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetReadStream(object[] incomingData, int pos = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void SetWriteStream(List<object> newWriteData, int pos = 0)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal List<object> GetWriteStream()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("Either SET the writeData with an empty List or use Clear().")]
		internal void ResetWriteStream()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object ReceiveNext()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object PeekNext()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendNext(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete("writeData is a list now. Use and re-use it directly.")]
		public bool CopyToListAndClear(List<object> target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object[] ToArray()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref bool myBool)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref int myInt)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref char value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref short value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref float obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref Player obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref Vector3 obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref Vector2 obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(ref Quaternion obj)
		{
			throw null;
		}
	}
}
