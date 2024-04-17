namespace Sirenix.Serialization
{
	public enum EntryType : byte
	{
		Invalid = 0,
		String = 1,
		Guid = 2,
		Integer = 3,
		FloatingPoint = 4,
		Boolean = 5,
		Null = 6,
		StartOfNode = 7,
		EndOfNode = 8,
		InternalReference = 9,
		ExternalReferenceByIndex = 10,
		ExternalReferenceByGuid = 11,
		StartOfArray = 12,
		EndOfArray = 13,
		PrimitiveArray = 14,
		EndOfStream = 15,
		ExternalReferenceByString = 16
	}
}
