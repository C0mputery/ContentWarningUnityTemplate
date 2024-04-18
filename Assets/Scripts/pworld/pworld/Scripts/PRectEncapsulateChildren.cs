using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace pworld.Scripts
{
	public class PRectEncapsulateChildren : MonoBehaviour, ILayoutSelfController, ILayoutController
	{
		public RectTransform parent;

		private RectTransform me;

		public RectTransform Me
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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
		public void Encapuslate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayoutHorizontal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayoutVertical()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PRectEncapsulateChildren()
		{

		}
	}
}
