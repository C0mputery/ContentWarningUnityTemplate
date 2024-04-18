using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EPOOutline
{
	public class MeshPool
	{
		private Queue<Mesh> freeMeshes;

		private List<Mesh> allMeshes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Mesh AllocateMesh()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseAllMeshes()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MeshPool()
		{

		}
	}
}
