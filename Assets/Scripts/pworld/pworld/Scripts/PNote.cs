using System.Runtime.CompilerServices;
using UnityEngine;

namespace pworld.Scripts
{
	public class PNote : MonoBehaviour
	{
		[TextArea]
		public string note;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PNote()
		{

		}
	}
}
