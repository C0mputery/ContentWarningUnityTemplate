using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Photon.Chat.Demo
{
	[RequireComponent(typeof(ChatGui))]
	public class NamePickGui : MonoBehaviour
	{
		private const string UserNamePlayerPref = "NamePickUserName";

		public ChatGui chatNewComponent;

		public InputField idInput;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndEditOnEnter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartChat()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NamePickGui()
		{
			throw null;
		}
	}
}
