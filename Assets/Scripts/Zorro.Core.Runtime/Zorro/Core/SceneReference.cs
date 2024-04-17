using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	[Serializable]
	public class SceneReference : ISerializationCallbackReceiver
	{
		[SerializeField]
		private string scenePath;

		public string ScenePath
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator string(SceneReference sceneReference)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeforeSerialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnAfterDeserialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SceneReference()
		{
			throw null;
		}
	}
}
