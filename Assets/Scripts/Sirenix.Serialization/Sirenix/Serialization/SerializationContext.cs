using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Sirenix.Serialization.Utilities;

namespace Sirenix.Serialization
{
	public sealed class SerializationContext : ICacheNotificationReceiver
	{
		private SerializationConfig config;

		private Dictionary<object, int> internalReferenceIdMap;

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
		public SerializationContext()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializationContext(StreamingContext context)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializationContext(FormatterConverter formatterConverter)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SerializationContext(StreamingContext context, FormatterConverter formatterConverter)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetInternalReferenceId(object reference, out int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryRegisterInternalReference(object reference, out int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryRegisterExternalReference(object obj, out int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryRegisterExternalReference(object obj, out Guid guid)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryRegisterExternalReference(object obj, out string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetInternalReferences()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetToDefault()
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
