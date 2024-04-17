using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace WebSocketSharp.Net
{
	[Serializable]
	[ComVisible(true)]
	public class WebHeaderCollection : NameValueCollection, ISerializable
	{
		private static readonly Dictionary<string, HttpHeaderInfo> _headers;

		private bool _internallyUsed;

		private HttpHeaderType _state;

		internal HttpHeaderType State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override string[] AllKeys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public override int Count
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string this[HttpRequestHeader header]
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

		public string this[HttpResponseHeader header]
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

		public override KeysCollection Keys
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static WebHeaderCollection()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal WebHeaderCollection(HttpHeaderType state, bool internallyUsed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected WebHeaderCollection(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WebHeaderCollection()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void add(string name, string value, HttpHeaderType headerType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkAllowed(HttpHeaderType headerType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string checkName(string name, string paramName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void checkRestricted(string name, HttpHeaderType headerType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string checkValue(string value, string paramName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpHeaderInfo getHeaderInfo(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string getHeaderName(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static HttpHeaderType getHeaderType(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isMultiValue(string name, bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool isRestricted(string name, bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void set(string name, string value, HttpHeaderType headerType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalRemove(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalSet(string header, bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void InternalSet(string name, string value, bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string ToStringMultiValue(bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void AddWithoutValidate(string headerName, string headerValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(string header)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(HttpRequestHeader header, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Add(HttpResponseHeader header, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Add(string name, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Clear()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string Get(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string Get(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator GetEnumerator()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string GetKey(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string[] GetValues(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string[] GetValues(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsRestricted(string headerName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsRestricted(string headerName, bool response)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeserialization(object sender)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Remove(HttpRequestHeader header)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Remove(HttpResponseHeader header)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Remove(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(HttpRequestHeader header, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(HttpResponseHeader header, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Set(string name, string value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] ToByteArray()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			throw null;
		}
	}
}
