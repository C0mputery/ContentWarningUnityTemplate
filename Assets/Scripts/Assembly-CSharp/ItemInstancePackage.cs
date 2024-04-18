using System;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Unity.Collections;
using Zorro.Core.Serizalization;
using Zorro.PhotonUtility;

public class ItemInstancePackage : CustomCommandPackage<CustomCommandType>
{
	public Guid ItemInstanceGuid;

	public ItemRPC ItemRPC;

	public NativeArray<byte> Data;

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
	public ItemInstancePackage()
	{

	}
}
