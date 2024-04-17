using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class POnEnableNOnDisable : MonoBehaviour
	{
		public MonoBehaviour creator;

		public Action OnDisabled;

		public Action OnEnabled;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool RemoveByCreator(GameObject host, MonoBehaviour creator)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public POnEnableNOnDisable()
		{
			throw null;
		}
	}
}
