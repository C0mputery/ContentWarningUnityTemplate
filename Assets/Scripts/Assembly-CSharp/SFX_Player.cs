using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class SFX_Player : MonoBehaviour
{
	[Serializable]
	public class SFX_Source
	{
		public AudioSource source;

		public SFX_Player player;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopPlaying()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartPlaying()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SFX_Source()
		{
			throw null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CIPlaySFX_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SFX_Player _003C_003E4__this;

		public SFX_Instance SFX;

		public SFX_Source source;

		public SFX_Settings overrideSettings;

		public Vector3 position;

		public float volumeMultiplier;

		public bool local;

		public Transform followTransform;

		private SFX_Settings _003Csettings_003E5__2;

		private float _003Cc_003E5__3;

		private float _003Ct_003E5__4;

		private Vector3 _003CrelativePos_003E5__5;

		object IEnumerator<object>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public _003CIPlaySFX_003Ed__13(int _003C_003E1__state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			throw null;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw null;
		}
	}

	private GameObject defaultSource;

	private Dictionary<SFX_Instance, List<SFX_Source>> sources;

	public static SFX_Player instance;

	public AudioMixerGroup boostGroup;

	private int nrOfSoundsPlayed;

	private List<SFX_Source> availibleSources;

	public Action<Vector3, float, int> playNoiseAction;

	[SerializeField]
	private AudioClip warmupClip;

	internal List<SoundBooster> soundBoosters;

	public AnimationCurve defaultCurve;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlaySFX(SFX_Instance SFX, Vector3 position, Transform followTransform = null, SFX_Settings overrideSettings = null, float volumeMultiplier = 1f, bool loop = false, bool local = false, bool isNoise = true, float stepNoiseMultiplier = 0f, int alerts = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayNoise(Vector3 position, float distance = 15f, int alerts = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(_003CIPlaySFX_003Ed__13))]
	private IEnumerator IPlaySFX(SFX_Source source, SFX_Instance SFX, Vector3 position, Transform followTransform, SFX_Settings overrideSettings, float volumeMultiplier, bool local)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RemoveSource(SFX_Source source, SFX_Instance sfx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetBoostValue(Vector3 position)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetBoostValue(Vector3 position, out float distance)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SFX_Source GetAvailibleSource()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SFX_Source CreateNewSource()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SFX_Player()
	{
		throw null;
	}
}
