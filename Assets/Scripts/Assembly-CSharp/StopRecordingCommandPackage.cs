using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Zorro.Core.Serizalization;
using Zorro.PhotonUtility;

public class StopRecordingCommandPackage : CustomCommandPackage<CustomCommandType>
{
	public Guid CameraDataGuid;

	public bool IsValidClip;

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
	public StopRecordingCommandPackage()
	{

	}
}
