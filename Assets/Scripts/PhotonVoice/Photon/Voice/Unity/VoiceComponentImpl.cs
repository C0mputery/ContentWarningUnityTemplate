using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

namespace Photon.Voice.Unity
{
	public class VoiceComponentImpl
	{
		private class LoggerImpl : ILogger
		{
			private VoiceLogger voiceLogger;

			private Object obj;

			private string objName;

			private string tag;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetVoiceLogger(VoiceLogger voiceLogger, Object obj, string tag)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetObjName(string n)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void Log(DebugLevel level, string fmt, params object[] args)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void LogError(string fmt, params object[] args)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void LogWarning(string fmt, params object[] args)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void LogInfo(string fmt, params object[] args)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void LogDebug(string fmt, params object[] args)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public LoggerImpl()
			{
				throw null;
			}
		}

		private VoiceLogger voiceLogger;

		private LoggerImpl logger;

		public ILogger Logger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public VoiceLogger VoiceLogger
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public string Name
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake(MonoBehaviour mb)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VoiceComponentImpl()
		{

		}
	}
}
