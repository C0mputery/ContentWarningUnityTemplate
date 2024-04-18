using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Unity.Collections;
using Zorro.Core.Serizalization;
using Zorro.PhotonUtility;

public class SendVideoChunkPackage : CustomCommandPackage<CustomCommandType>
{
	public ushort ChunkCount;

	public ushort ChunkIndex;

	public VideoHandle VideoHandle;

	public ClipID ClipID;

	public byte[] VideoChunkData;

	public NativeArray<byte> ContentEventData;

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
	public SendVideoChunkPackage()
	{

	}
}
