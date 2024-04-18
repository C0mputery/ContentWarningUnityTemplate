using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Photon.Voice
{
	public abstract class DeviceEnumeratorBase : IDeviceEnumerator, IDisposable, IEnumerable<DeviceInfo>, IEnumerable
	{
		protected List<DeviceInfo> devices;

		protected ILogger logger;

		private Action onReady;

		public virtual bool IsSupported
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public virtual string Error
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

		public Action OnReady
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected get
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
		public DeviceEnumeratorBase(ILogger logger)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator<DeviceInfo> GetEnumerator()
		{
			throw null;
		}

		public abstract void Refresh();

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		public abstract void Dispose();
	}
}
