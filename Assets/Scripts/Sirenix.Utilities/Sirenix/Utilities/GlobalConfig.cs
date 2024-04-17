using System.Runtime.CompilerServices;
using UnityEngine;

namespace Sirenix.Utilities
{
	public abstract class GlobalConfig<T> : ScriptableObject, IGlobalConfigEvents where T : GlobalConfig<T>, new()
	{
		private static GlobalConfigAttribute configAttribute;

		private static T instance;

		public static GlobalConfigAttribute ConfigAttribute
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static bool HasInstanceLoaded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public static T Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LoadInstanceIfAssetExists()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInEditor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnConfigInstanceFirstAccessed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnConfigAutoCreated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IGlobalConfigEvents.OnConfigAutoCreated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IGlobalConfigEvents.OnConfigInstanceFirstAccessed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GlobalConfig()
		{
			throw null;
		}
	}
}
