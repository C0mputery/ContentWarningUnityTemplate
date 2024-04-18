using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerDataSounds : MonoBehaviour
{
	public Player player;

	private float prevHealth;

	private float prevStamina;

	public float dmg;

	public Animator dmgLvl1;

	public Animator dmgLvl2;

	public Animator dmgLvl3;

	public Animator heal;

	public Animator dead;

	public Animator stamina;

	public Animator staminaReturn;

	public Animator oxygen;

	public Animator oxygenReturn;

	public AudioSource staminaLoop;

	public AudioSource oxygenLoop;

	public AudioSource oxygenTimer;

	private bool t;

	private bool t2;

	private bool t3;

	public AudioSource throwCharge;

	public SFX_Instance throwStart;

	public SFX_Instance throwEndLvl1;

	public SFX_Instance throwEndLvl2;

	private float prevCharge;

	public SFX_Instance bedOn;

	public SFX_Instance bedOff;

	private bool sleepToggle;

	public AudioSource fallLoop;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerDataSounds()
	{

	}
}
