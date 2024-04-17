using System.Collections.Generic;

namespace DefaultNamespace
{
	public interface IHasPatrolGroup
	{
		List<PatrolPoint.PatrolGroup> GetGroup();
	}
}
