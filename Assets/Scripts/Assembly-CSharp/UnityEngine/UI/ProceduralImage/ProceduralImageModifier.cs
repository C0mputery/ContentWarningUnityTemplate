using System.Runtime.CompilerServices;

namespace UnityEngine.UI.ProceduralImage
{
	[DisallowMultipleComponent]
	public abstract class ProceduralImageModifier : MonoBehaviour
	{
		protected Graphic graphic;

		protected Graphic _Graphic
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public abstract Vector4 CalculateRadius(Rect imageRect);

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected ProceduralImageModifier()
		{
			throw null;
		}
	}
}
