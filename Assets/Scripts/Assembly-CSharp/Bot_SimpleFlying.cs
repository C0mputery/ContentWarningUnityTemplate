using System.Runtime.CompilerServices;
using UnityEngine;

public class Bot_SimpleFlying : MonoBehaviour
{
	private Transform root;

	public float speed;

	public float drag;

	[Range(0f, 1f)]
	public float perlinDragFacotor;

	public PerlinSampler perlin;

	private Vector3 vel;

	private Bot bot;

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
	public Bot_SimpleFlying()
	{

	}
}
