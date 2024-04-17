using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using pworld.Scripts.Extensions;

namespace pworld.Scripts
{
	public class TLSEntries : ScriptableObject
	{
		public List<SerializedCollection<GameObject>> back;

		public List<SerializedCollection<GameObject>> forward;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TLSEntries()
		{
			throw null;
		}
	}
}
