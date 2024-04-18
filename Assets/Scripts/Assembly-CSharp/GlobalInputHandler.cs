using System.Runtime.CompilerServices;
using UnityEngine;
using Zorro.Settings;

public class GlobalInputHandler : RetrievableSingleton<GlobalInputHandler>
{
	public class InputKey
	{
		public KeyCodeSetting KeyCodeSetting;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetKeybind(KeyCodeSetting getSetting)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetKeyDown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetKey()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool GetKeyUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public InputKey()
		{
			throw null;
		}
	}

	public static InputKey WalkForwardKey;

	public static InputKey WalkBackwardKey;

	public static InputKey WalkLeftKey;

	public static InputKey WalkRightKey;

	public static InputKey SprintKey;

	public static InputKey JumpKey;

	public static InputKey CrouchKey;

	public static InputKey InteractKey;

	public static InputKey DropKey;

	public static InputKey EmoteKey;

	public static InputKey ToggleSelfieModeKey;

	public static InputKey PushToTalkKey;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanTakeInput()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetKey(KeyCode keyCode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetKeyDown(KeyCode escape)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetKeyUp(KeyCode keyCode)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetMouseButtonDown(int button)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetMouseButtonUp(int button)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalInputHandler()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalInputHandler()
	{
		throw null;
	}
}
