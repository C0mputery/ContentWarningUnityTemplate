using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

public class AspectRatioUISetter : MonoBehaviour
{
	[Serializable]
	public class AspectPosition
	{
		public Vector2 anchoredPosition;

		public Vector2 anchoredMin;

		public Vector2 anchoredMax;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AspectPosition(RectTransform rectTransform)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Load(RectTransform rectTransform)
		{
			throw null;
		}
	}

	[Serializable]
	public class SavedAspectPosition
	{
		public AspectRatio aspectRatio;

		public AspectPosition aspectPosition;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SavedAspectPosition(AspectRatio aspectRatio, AspectPosition aspectPosition)
		{
			throw null;
		}
	}

	public AspectPosition defaultAspectPosition;

	public List<SavedAspectPosition> savedAspectPositions;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAspectPosition(AspectRatio aspectRatio)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadAspectPosition(AspectRatio aspectRatio)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AspectRatioUISetter()
	{

	}
}
