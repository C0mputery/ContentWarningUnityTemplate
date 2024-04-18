using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Zorro.Core.Serizalization;

public class ContentBuffer
{
	public class BufferedContent
	{
		public ContentEventFrame frame;

		public float score;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Serialize(BinarySerializer serializer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deserialize(BinaryDeserializer deserializer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufferedContent()
		{
			throw null;
		}
	}

	public class Streak
	{
		public ushort contentID;

		private List<BufferedContent> content;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndStreak(List<BufferedContent> buffer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PushFrame(ContentEventFrame frame)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Streak()
		{
			throw null;
		}
	}

	private struct UniqueContent
	{
		public ushort contentID;

		public int instanceID;
	}

	public List<BufferedContent> buffer;

	public Dictionary<ushort, Streak> currentStreaks;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContentBuffer()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PushFrame(List<ContentEventFrame> frames)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PickBest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBuffer(ContentBuffer contentBuffer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Comment> GenerateComments()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(BinarySerializer serializer)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ContentBuffer(BinaryDeserializer deserializer)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetScore()
	{
		throw null;
	}
}
