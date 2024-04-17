using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ExitGames.Client.Photon.StructWrapping
{
	public static class StructWrapperUtility
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Type GetWrappedType(this object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StructWrapper<T> Wrap<T>(this T value, bool persistant)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StructWrapper<T> Wrap<T>(this T value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StructWrapper<byte> Wrap(this byte value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static StructWrapper<bool> Wrap(this bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsType<T>(this object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T DisconnectPooling<T>(this T table) where T : IEnumerable<object>
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<object> ReleaseAllWrappers(this List<object> collection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object[] ReleaseAllWrappers(this object[] collection)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Hashtable ReleaseAllWrappers(this Hashtable table)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BoxAll(this Hashtable table, bool recursive = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T Unwrap<T>(this object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T Get<T>(this object obj)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T Unwrap<T>(this Hashtable table, object key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryUnwrapValue<T>(this Hashtable table, byte key, out T value) where T : new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryGetValue<T>(this Hashtable table, byte key, out T value) where T : new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryGetValue<T>(this Hashtable table, object key, out T value) where T : new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryUnwrapValue<T>(this Hashtable table, object key, out T value) where T : new()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T Unwrap<T>(this Hashtable table, byte key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T Get<T>(this Hashtable table, byte key)
		{
			throw null;
		}
	}
}
