using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using pworld.Scripts.Extensions;

namespace pworld.Scripts
{
	public class PScaleShake : MonoBehaviour, IPForceTaker
	{
		public bool useTimeScale;

		public Vector3 velocity;

		[FormerlySerializedAs("drag")]
		public float damp;

		public float spring;

		private Vector3 localIdleScale;

		private RectTransform rectT;

		private float scaleFactor;

		private Vector3 tarInLocal;

		public Vector3 TarInLocal
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

		public Vector3 LocalIdleScale
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

		public float ScaleFactor
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
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddForce(Vector3 force)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTarByFactor(float f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PScaleShake()
		{

		}
	}
}
