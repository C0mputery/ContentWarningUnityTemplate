using System.Runtime.CompilerServices;
using UnityEngine;

namespace Zorro.Core
{
	public class TextureCurve : ScriptableObject
	{
		[SerializeField]
		private AnimationCurve _red;

		[SerializeField]
		private AnimationCurve _green;

		[SerializeField]
		private AnimationCurve _blue;

		[SerializeField]
		private AnimationCurve _alpha;

		private Texture2D _texture;

		[SerializeField]
		private int _resolution;

		[SerializeField]
		private TextureWrapMode _wrapMode;

		[SerializeField]
		private FilterMode _filterMode;

		public Texture2D Texture
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Resolution
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture Bake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TextureCurve()
		{
			throw null;
		}
	}
}
