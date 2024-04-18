using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Photon.Chat.Demo
{
	public class FriendItem : MonoBehaviour
	{
		public Text NameLabel;

		public Text StatusLabel;

		public Text Health;

		[HideInInspector]
		public string FriendId
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
		public void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnFriendStatusUpdate(int status, bool gotMessage, object message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FriendItem()
		{

		}
	}
}
