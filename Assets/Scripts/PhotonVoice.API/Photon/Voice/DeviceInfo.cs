using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public struct DeviceInfo
	{
		private DeviceFeatures features;

		private bool useStringID;

		public static readonly DeviceInfo Default;

		public bool IsDefault
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public int IDInt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public string IDString
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
				throw null;
			}
		}

		public DeviceFeatures Features
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DeviceInfo(bool isDefault, int idInt, string idString, string name, DeviceFeatures features = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeviceInfo(int id, string name, DeviceFeatures features = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeviceInfo(string id, string name, DeviceFeatures features = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeviceInfo(string name, DeviceFeatures features = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator ==(DeviceInfo d1, DeviceInfo d2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator !=(DeviceInfo d1, DeviceInfo d2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DeviceInfo()
		{
			throw null;
		}
	}
}
