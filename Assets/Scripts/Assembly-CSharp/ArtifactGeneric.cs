using System.Runtime.CompilerServices;
using Photon.Pun;

public class ArtifactGeneric : ItemInstanceBehaviour, IArtifactContent
{
	private StashAbleEntry stashAbleEntry;

	public bool IsHeld
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ConfigItem(ItemInstanceData data, PhotonView playerView)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ArtifactGeneric()
	{
		throw null;
	}
}
