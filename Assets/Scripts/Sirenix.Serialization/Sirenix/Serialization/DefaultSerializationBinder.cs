using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class DefaultSerializationBinder : TwoWaySerializationBinder
	{
		private static readonly object ASSEMBLY_LOOKUP_LOCK;

		private static readonly Dictionary<string, Assembly> assemblyNameLookUp;

		private static readonly Dictionary<string, Type> customTypeNameToTypeBindings;

		private static readonly object TYPETONAME_LOCK;

		private static readonly Dictionary<Type, string> nameMap;

		private static readonly object NAMETOTYPE_LOCK;

		private static readonly Dictionary<string, Type> typeMap;

		private static readonly object ASSEMBLY_REGISTER_QUEUE_LOCK;

		private static readonly List<Assembly> assembliesQueuedForRegister;

		private static readonly List<AssemblyLoadEventArgs> assemblyLoadEventsQueuedForRegister;

		[MethodImpl(MethodImplOptions.NoInlining)]
		static DefaultSerializationBinder()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RegisterAllQueuedAssembliesRepeating()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool RegisterQueuedAssemblies()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool RegisterQueuedAssemblyLoadEvents()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void RegisterAssembly(Assembly assembly)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string BindToName(Type type, DebugContext debugContext = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ContainsType(string typeName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Type BindToType(string typeName, DebugContext debugContext = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type ParseTypeName(string typeName, DebugContext debugContext)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void ParseName(string fullName, out string typeName, out string assemblyName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private Type ParseGenericAndOrArrayType(string typeName, DebugContext debugContext)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool TryParseGenericAndOrArrayTypeName(string typeName, out string actualTypeName, out bool isGeneric, out List<string> genericArgNames, out bool isArray, out int arrayRank)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static char Peek(string str, int i, int ahead)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool ReadGenericArg(string typeName, ref int i, out string argName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DefaultSerializationBinder()
		{

		}
	}
}
