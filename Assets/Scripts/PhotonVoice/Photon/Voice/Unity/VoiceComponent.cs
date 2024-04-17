using System.Runtime.CompilerServices;
using UnityEngine;

namespace Photon.Voice.Unity
{
	[HelpURL("https://doc.photonengine.com/en-us/voice/v2")]
	public abstract class VoiceComponent : MonoBehaviour
	{
		private VoiceComponentImpl impl;

		protected ILogger Logger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public VoiceLogger VoiceLogger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected VoiceComponent()
		{
			throw null;
		}
	}
}
