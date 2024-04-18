using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class VideoInfoEntry : ItemDataEntry, IHaveUIData
{
	public VideoHandle videoID;

	public float timeLeft;

	public float maxTime;

	public bool isRecording
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			throw null;
		}
	}

	public bool isFlipped
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
			throw null;
		}
	}

	public float timeRecorded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool StartedRecording
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Serialize(BinarySerializer binarySerializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Deserialize(BinaryDeserializer binaryDeserializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetString()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetPercentage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoInfoEntry()
	{

	}
}
