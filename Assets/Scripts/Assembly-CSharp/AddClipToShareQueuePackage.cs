using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Zorro.Core.Serizalization;
using Zorro.PhotonUtility;

public class AddClipToShareQueuePackage : CustomCommandPackage<CustomCommandType>
{
	public VideoHandle VideoHandle;

	public ClipID ClipID;

	public int ClipOwner;

	public bool isReRequest;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SerializeData(BinarySerializer binarySerializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DeserializeData(BinaryDeserializer binaryDeserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CustomCommandType GetCommandType()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override SendOptions GetSendOptions()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AddClipToShareQueuePackage()
	{

	}
}
