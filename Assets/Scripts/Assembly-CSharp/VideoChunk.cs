using System.Runtime.CompilerServices;
using Unity.Collections;

public class VideoChunk
{
	private byte[][] m_chunks;

	public ContentBuffer contentBuffer;

	private int m_ChunksCompleted;

	private int m_TotalBytes;

	public ClipID ClipID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public VideoHandle VideoID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public byte[] ChunkData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public int NumberOfChunks
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	public bool Completed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VideoChunk(ushort chunkCount, ushort chunkIndex, byte[] chunk, ClipID clipID, VideoHandle videoID, NativeArray<byte> contentEventData)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddChunk(byte[] chunkData, ushort chunkIndex, NativeArray<byte> contentEventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddChunk(ushort index, byte[] chunkData, NativeArray<byte> contentEventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void IncrementChunksCompleted()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckIfComplete()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeVideo()
	{
		throw null;
	}
}
