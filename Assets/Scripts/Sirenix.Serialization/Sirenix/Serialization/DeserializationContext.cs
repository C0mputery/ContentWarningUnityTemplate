using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	public sealed class DeserializationContext : ICacheNotificationReceiver
	{
		private SerializationConfig config;

		private Dictionary<int, object> internalIdReferenceMap;

		private StreamingContext streamingContext;

		private IFormatterConverter formatterConverter;

		private TwoWaySerializationBinder binder;

		public TwoWaySerializationBinder Binder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public IExternalStringReferenceResolver StringReferenceResolver
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public IExternalGuidReferenceResolver GuidReferenceResolver
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public IExternalIndexReferenceResolver IndexReferenceResolver
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public StreamingContext StreamingContext
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public IFormatterConverter FormatterConverter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public SerializationConfig Config
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
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
		public DeserializationContext()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeserializationContext(StreamingContext context)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeserializationContext(FormatterConverter formatterConverter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeserializationContext(StreamingContext context, FormatterConverter formatterConverter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterInternalReference(int id, object reference)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetInternalReference(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetExternalObject(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetExternalObject(Guid guid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public object GetExternalObject(string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICacheNotificationReceiver.OnFreed()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void ICacheNotificationReceiver.OnClaimed()
		{
			throw null;
		}
	}
}
