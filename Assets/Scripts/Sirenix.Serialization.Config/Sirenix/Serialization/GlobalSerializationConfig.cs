using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

namespace Sirenix.Serialization
{
	[HideMonoScript]
	[SirenixGlobalConfig]
	public class GlobalSerializationConfig : GlobalConfig<GlobalSerializationConfig>
	{
		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_TEXT = "Odin's custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nWarning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin's. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!";

		public const string ODIN_PREFAB_CAUTIONARY_WARNING_TEXT = "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nUsing prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs.";

		public const string ODIN_SERIALIZATION_CAUTIONARY_WARNING_BUTTON_TEXT = "I know what I'm about, son. Hide message forever.";

		public const string ODIN_PREFAB_CAUTIONARY_WARNING_BUTTON_TEXT = "I understand that I'm on my own. Hide message forever.";

		private static readonly DataFormat[] BuildFormats;

		[Title("Warning messages", null, TitleAlignments.Left, true, true)]
		[ToggleLeft]
		[DetailedInfoBox("Click to show warning message.", "Odin's custom serialization protocol is stable and fast. It is built to be fast, reliable and resilient above all.\n\n*Words of caution* \nHowever, caveats apply - there is a reason Unity chose such a drastically limited serialization protocol. It keeps things simple and manageable, and limits how much complexity you can introduce into your data structures. It can be very easy to get carried away and shoot yourself in the foot when all limitations suddenly disappear, and hence we have included this cautionary warning.\n\nWarning words aside, there can of course be valid reasons to use a more powerful serialization protocol such as Odin's. However, we advise you to use it wisely and with restraint. After all, with great power comes great responsibility!", InfoMessageType.Info, null)]
		public bool HideSerializationCautionaryMessage;

		[ToggleLeft]
		[DetailedInfoBox("Click to show warning message.", "In 2018.3, Unity introduced a new prefab workflow, and in so doing, changed how all prefabs fundamentally work. Despite our best efforts, we have so far been unable to achieve a stable implementation of Odin-serialized prefab modifications on prefab instances and variants in the new prefab workflow.This has nothing to do with Odin serializer itself, which remains rock solid. Odin-serialized ScriptableObjects and non-prefab Components/Behaviours are still perfectly stable - you are only seeing this message because this is an Odin-serialized prefab asset or instance.\n\nUsing prefabs with Odin serialization in 2018.3 and above is considered a *deprecated feature* and is officially unsupported. In short, if you disregard this message and then experience issues, we will not be able to help or support you.\n\nPlease keep all this in mind, if you wish to continue using Odin-serialized prefabs.", InfoMessageType.Info, null)]
		public bool HidePrefabCautionaryMessage;

		[ToggleLeft]
		[SerializeField]
		[InfoBox("Enabling this will hide all warning messages that will show up in the inspector when the OdinSerialize attribute potentially does not achieve the desired effect.", InfoMessageType.Info, null)]
		public bool HideOdinSerializeAttributeWarningMessages;

		[SerializeField]
		[ToggleLeft]
		[LabelText("Hide Non-Serialized SerializeField/ShowInInspector Warning Messages")]
		[InfoBox("Enabling this will hide all warning messages that show up when the SerializeField and the ShowInInspector attributes are used together on non-serialized fields or properties.", InfoMessageType.Info, null)]
		public bool HideNonSerializedShowInInspectorWarningMessages;

		[SerializeField]
		[Title("Data formatting options", null, TitleAlignments.Left, true, true)]
		[ValueDropdown("BuildFormats")]
		private DataFormat buildSerializationFormat;

		[SerializeField]
		private DataFormat editorSerializationFormat;

		[SerializeField]
		[Title("Logging and error handling", null, TitleAlignments.Left, true, true)]
		private LoggingPolicy loggingPolicy;

		[SerializeField]
		private ErrorHandlingPolicy errorHandlingPolicy;

		public ILogger Logger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public DataFormat EditorSerializationFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public DataFormat BuildSerializationFormat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public LoggingPolicy LoggingPolicy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public ErrorHandlingPolicy ErrorHandlingPolicy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[OnInspectorGUI]
		private void OnInspectorGUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GlobalSerializationConfig()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static GlobalSerializationConfig()
		{
			throw null;
		}
	}
}
