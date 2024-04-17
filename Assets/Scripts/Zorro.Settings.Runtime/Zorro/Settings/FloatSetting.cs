using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;
using Zorro.Settings.DebugUI;

namespace Zorro.Settings
{
	public abstract class FloatSetting : Setting
	{
		public float Value
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public float MinValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		public float MaxValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Load(ISettingsSaveLoad loader)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Save(ISettingsSaveLoad saver)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override SettingUI GetDebugUI(ISettingHandler settingHandler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GameObject GetSettingUICell()
		{
			throw null;
		}

		protected abstract float GetDefaultValue();

		protected abstract float2 GetMinMaxValue();

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetValue(float value, ISettingHandler handler)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual float Clamp(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual string Expose(float result)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected FloatSetting()
		{
			throw null;
		}
	}
}
