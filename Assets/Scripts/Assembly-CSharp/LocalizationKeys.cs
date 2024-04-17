using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Localization;

public class LocalizationKeys
{
	public enum Keys
	{
		HelmetWelcome = 0,
		HelmetFailed = 1,
		Sleep = 2,
		Day = 3,
		Views = 4,
		Quota = 5,
		Money = 6,
		Empty = 7,
		Save = 8,
		DivingBellNotReadyMissingPlayersState = 9,
		DivingBellNotReadyDoorOpenState = 10,
		DivingBellReady = 11,
		DivingBellReadySurface = 12,
		DivingBellRechargingState = 13,
		JoinRandom = 14,
		EnterDiveBellDay2Objective = 15,
		EnterDiveBellObjective = 16,
		BuyEquipmentObjective = 17,
		ExtractVideoObjective = 18,
		FilmSomethingScaryObjective = 19,
		GoToBedFailedObjective = 20,
		GoToBedSuccessObjective = 21,
		InviteFriendsObjective = 22,
		LeaveHouseObjective = 23,
		PickupDiscObjective = 24,
		PickupTheCameraObjective = 25,
		ReturnToTheDiveBellObjective = 26,
		UploadVideoObjective = 27,
		WakeUpObjective = 28,
		CelebrateObjective = 29,
		DaysLeft = 30,
		LastDay = 31,
		Buy = 32,
		Left = 33,
		Right = 34,
		NotSleepy = 35,
		StartGame = 36,
		Submerge = 37,
		ReturnToSurface = 38,
		TerminalBusy = 39,
		Help = 40,
		InviteFriends = 41,
		Open = 42,
		Close = 43,
		GameFull = 44,
		GameStarted = 45,
		Offline = 46,
		StartGameTitle = 47,
		StartGameBody = 48,
		StartGameConfirm = 49,
		Cancel = 50,
		PickUp = 51,
		SwitchCategory = 52,
		AddToCart = 53,
		SoldOut = 54,
		Clear = 55,
		Order = 56,
		DeleteSave = 57,
		DeleteSaveConfirm = 58,
		Yes = 59,
		No = 60,
		Interact = 61,
		HelmetDaysLeft = 62,
		HelmetLastDay = 63,
		HelmetForgetCamera = 64,
		Oxygen = 65,
		Distance = 66,
		Items = 67,
		CloseVideo = 68,
		ReplayVideo = 69,
		SaveVideo = 70,
		UploadToSpookTube = 71,
		ShopClosed = 72,
		Lights = 73,
		Medical = 74,
		Gadgets = 75,
		Emotes = 76,
		Emotes2 = 77,
		Upgrades = 78,
		Misc = 79,
		SpookTubeViews = 80,
		AdRevenue = 81,
		HospitalBill = 82,
		CalibrationUseVoice = 83,
		CalibrationUseHeadphones = 84,
		CalibrationSelectMic = 85,
		CalibrationSelectVoice = 86,
		CalibrationBrightness = 87,
		CalibrationMonster = 88,
		Brightness = 89,
		Continue = 90,
		OldVersion = 91,
		PleaseUpdate = 92,
		CloseGame = 93,
		CrouchKeybindSetting = 94,
		DropKeybindSetting = 95,
		EmoteKeybindSetting = 96,
		InteractKeybindSetting = 97,
		JumpKeybindSetting = 98,
		ToggleSelfieModeKeybindSetting = 99,
		WalkBackwardKeybindSetting = 100,
		WalkForwardKeybindSetting = 101,
		WalkLeftKeybindSetting = 102,
		WalkRightKeybindSetting = 103,
		AmbientOcclusionSetting = 104,
		BrightnessSetting = 105,
		ChromaticAberrationSetting = 106,
		FullscreenSetting = 107,
		VoiceVolumeSetting = 108,
		VoiceSetting = 109,
		VoiceChatModeSetting = 110,
		VSyncSetting = 111,
		ShadowQualitySetting = 112,
		ScreenResolutionSetting = 113,
		SFXVolumeSetting = 114,
		MouseSensitivitySetting = 115,
		MaxFramerateSetting = 116,
		MasterVolumeSetting = 117,
		SprintKeybindSetting = 118,
		JoinError = 119,
		JoinErrorMismatch = 120,
		Ok = 121,
		VideoSaved = 122,
		VideoSavedAs = 123,
		VideoFailedSave = 124,
		ServerIssues = 125,
		DropItem = 126,
		Battery = 127,
		FilmLeft = 128,
		ToggleLight = 129,
		ZoomKey = 130,
		SelfieMode = 131,
		Aim = 132,
		HostingGame = 133,
		Connecting = 134,
		BoomMic = 135,
		Camera = 136,
		CameraBroken = 137,
		Clapper = 138,
		Defibrilator = 139,
		Disc = 140,
		Flare = 141,
		GooBall = 142,
		Hugger = 143,
		LongFlashlightPro = 144,
		LongFlashlight = 145,
		ModernFlashlightPro = 146,
		ModernFlashlight = 147,
		OldFlashlight = 148,
		PartyPopper = 149,
		ShockStick = 150,
		SoundPlayer = 151,
		WalkieTalkie = 152,
		WideFlashlight2 = 153,
		WideFlashlight3 = 154,
		Winch = 155,
		Aminalstateu = 156,
		Animalstatue = 157,
		Bone = 158,
		Brainonastick = 159,
		Chorby = 160,
		Container = 161,
		OldPainting = 162,
		Radio = 163,
		Ribcage = 164,
		Skull = 165,
		Spine = 166,
		ReporterMic = 167,
		Emote_Applause = 168,
		Emote_Dance1 = 169,
		Emote_Dance2 = 170,
		Emote_Dance3 = 171,
		Emote_FingerScratch = 172,
		Emote_HalfBackflip = 173,
		Emote_Handstand = 174,
		Emote_HuggerHeal = 175,
		Emote_JumpJack = 176,
		Emote_MiddleFings = 177,
		Emote_Peace = 178,
		Emote_PushUp = 179,
		Emote_Shrug = 180,
		Emote_Stretch = 181,
		Emote_Thumbnail1 = 182,
		Emote_Thumbnail2 = 183,
		Emote_ThumbsUp = 184,
		BoomMic_ToolTips = 185,
		Camera_ToolTips = 186,
		Clapper_ToolTips = 187,
		Defibrilator_ToolTips = 188,
		Disc_ToolTips = 189,
		FakeOldFlashlight_ToolTips = 190,
		Flare_ToolTips = 191,
		GooBall_ToolTips = 192,
		Hugger_ToolTips = 193,
		LongFlashlightPro_ToolTips = 194,
		LongFlashlight_ToolTips = 195,
		LostDisc_ToolTips = 196,
		ModernFlashlightPro_ToolTips = 197,
		ModernFlashlight_ToolTips = 198,
		OldFlashlight_ToolTips = 199,
		PartyPopper_ToolTips = 200,
		ReporterMic_ToolTips = 201,
		ShockStick_ToolTips = 202,
		SoundPlayer_ToolTips = 203,
		WalkieTalkie_ToolTips = 204,
		WideFlashlight2_ToolTips = 205,
		WideFlashlight3_ToolTips = 206,
		Radio_ToolTips = 207,
		Emote_Applause_ToolTips = 208,
		Emote_Dance1_ToolTips = 209,
		Emote_Dance2_ToolTips = 210,
		Emote_Dance3_ToolTips = 211,
		Emote_FingerScratch_ToolTips = 212,
		Emote_HalfBackflip_ToolTips = 213,
		Emote_Handstand_ToolTips = 214,
		Emote_HuggerHeal_ToolTips = 215,
		Emote_JumpJack_ToolTips = 216,
		Emote_MiddleFings_ToolTips = 217,
		Emote_Peace_ToolTips = 218,
		Emote_PushUp_ToolTips = 219,
		Emote_Shrug_ToolTips = 220,
		Emote_Stretch_ToolTips = 221,
		Emote_Thumbnail1_ToolTips = 222,
		Emote_Thumbnail2_ToolTips = 223,
		Emote_ThumbsUp_ToolTips = 224
	}

	private static Dictionary<Keys, string> m_StringDictionary;

	private static Dictionary<Locale, Dictionary<Keys, string>> m_LanguageStrings;

	private static bool m_MadeLocaleStrings;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetLocalizedString(Keys key)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetLocalizedInternal(Locale locale, Keys key)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void MakeLocaleStrings()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void OnLanguageSwitch()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocalizationKeys()
	{
		throw null;
	}
}