using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Core;

namespace DefaultNamespace
{
	[CreateAssetMenu(fileName = "LostFootageDatabase", menuName = "LostFootageDatabase")]
	public class LostFootageDatabase : SingletonAsset<LostFootageDatabase>
	{
		[Serializable]
		public class FootageRarityPair
		{
			public FileInfo fileInfo;

			public int score;

			public string name;

			public int rarity;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public static bool FromFileInfo(FileInfo info, out FootageRarityPair pair)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public FootageRarityPair()
			{
				throw null;
			}
		}

		public List<FootageRarityPair> footageRarityPairs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintChances()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetFootageByIndex(int i, out FootageRarityPair footage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetRandomLostFootageIndex()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryGetLostFootage(LostFootageHandle handle, out FootageRarityPair footage)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LostFootageDatabase()
		{

		}
	}
}
