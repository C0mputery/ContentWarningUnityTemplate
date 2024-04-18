using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Realtime
{
	internal class MonoBehaviourEmpty : MonoBehaviour
	{
		internal Action<RegionHandler> onCompleteCall;

		private RegionHandler obj;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MonoBehaviourEmpty BuildInstance(string id = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelfDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CompleteOnMainThread(RegionHandler obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCoroutineAndDestroy(IEnumerator coroutine)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MonoBehaviourEmpty()
		{

		}
	}
}
