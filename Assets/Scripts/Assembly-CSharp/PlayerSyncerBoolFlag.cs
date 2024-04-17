using System;

[Flags]
public enum PlayerSyncerBoolFlag : byte
{
	NONE = 0,
	SPRINT = 1,
	CROUCH = 2,
	WALK_RIGHT = 4,
	WALK_LEFT = 8,
	WALK_FORWARD = 0x10,
	WALK_BACKWARD = 0x20,
	AIMING = 0x40
}
