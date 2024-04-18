using System.Runtime.CompilerServices;

public class StartGameDoorInteractable : Interactable
{
	private SurfaceNetworkHandler m_NetworkHandler;

	private string m_StartGameTitleText;

	private string m_StartGameBody;

	private string m_StartGameConfirmText;

	private string m_CancelText;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Interact(Player player)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StartGameDoorInteractable()
	{

	}
}
