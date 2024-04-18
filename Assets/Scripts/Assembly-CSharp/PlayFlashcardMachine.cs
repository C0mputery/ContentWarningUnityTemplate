using System.Runtime.CompilerServices;

public class PlayFlashcardMachine : Interactable
{
	public VideoPlaybackScreen playbackScreen;

	public Item m_flashCardItem;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayFlashcardMachine()
	{

	}
}
