namespace Photon.Realtime
{
	internal enum RoomOptionBit
	{
		CheckUserOnJoin = 1,
		DeleteCacheOnLeave = 2,
		SuppressRoomEvents = 4,
		PublishUserId = 8,
		DeleteNullProps = 0x10,
		BroadcastPropsChangeToAll = 0x20,
		SuppressPlayerInfo = 0x40
	}
}
