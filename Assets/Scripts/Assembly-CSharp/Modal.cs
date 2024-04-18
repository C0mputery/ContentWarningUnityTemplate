using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using Zorro.Core;
using Zorro.Core.CLI;

public class Modal : RetrievableResourceSingleton<Modal>
{
	public Transform ButtonContainer;

	public TextMeshProUGUI TitleText;

	public TextMeshProUGUI BodyText;

	public GameObject m_buttonPrefab;

	public CanvasGroup m_canvasGroup;

	private bool m_show;

	public bool Open
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnCreated()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Show(string title, string body, ModalOption[] options, Action onClosed = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ShowModal(string title, string body, ModalOption[] options, Action onClosed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ConsoleCommand]
	public static void ShowTest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ShowError(string title, string body)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Modal()
	{

	}
}
