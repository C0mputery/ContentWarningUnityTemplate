using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace pworld.Scripts
{
	public class PTextLerp : MonoBehaviour
	{
		[Serializable]
		public class LerpValues
		{
			public float spring;

			public float drag;

			public float speed;

			public float haxx;

			public float min;

			public float max;

			public float iSpeedMul;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LerpValues()
			{
				throw null;
			}
		}

		[Serializable]
		public class StringLerp
		{
			[CompilerGenerated]
			private sealed class _003CLerp_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public StringLerp _003C_003E4__this;

				private float _003Cstart_003E5__2;

				private int _003Ci_003E5__3;

				private CharLerp _003Citem_003E5__4;

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
				public _003CLerp_003Ed__2(int _003C_003E1__state)
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

			[SerializeField]
			public List<CharLerp> letters;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GimmeString()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[IteratorStateMachine(typeof(_003CLerp_003Ed__2))]
			public IEnumerator Lerp()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public StringLerp()
			{
				throw null;
			}
		}

		[Serializable]
		public class CharLerp
		{
			public char goal;

			public float velocity;

			public bool useTimeScale;

			public float iSpeed;

			public bool print;

			private float curInFloat;

			private char current;

			private LerpValues values;

			public bool Done
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			public char Current
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
			public CharLerp(char g, char cur, LerpValues lerpVals)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void PhysicsLerp()
			{
				throw null;
			}
		}

		public LerpValues lerpVals;

		public StringLerp stringLerp;

		private TMP_InputField tmpInput;

		private TextMeshProUGUI tmpText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ValChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Lerp(string newText)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PTextLerp()
		{

		}
	}
}
