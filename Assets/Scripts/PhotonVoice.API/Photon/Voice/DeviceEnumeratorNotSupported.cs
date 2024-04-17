using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	internal class DeviceEnumeratorNotSupported : DeviceEnumeratorBase
	{
		private string message;

		public override bool IsSupported
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override string Error
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeviceEnumeratorNotSupported(ILogger logger, string message) : base(null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Refresh()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Dispose()
		{
			throw null;
		}
	}
}
