using System.Runtime.CompilerServices;
using Photon.Pun;

public abstract class MonsterContentProvider : ContentProvider
{
	private PhotonView photonView;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public T GetContentEvent<T>() where T : MonsterContentEvent, new()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected MonsterContentProvider()
	{
		throw null;
	}
}
