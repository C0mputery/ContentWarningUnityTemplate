using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PFakeSingleton<T> : MonoBehaviour where T : Component
	{
		private static T me;

		public static T Me
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PFakeSingleton()
		{
			throw null;
		}
	}
}
