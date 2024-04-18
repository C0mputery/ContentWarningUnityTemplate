using System;
using System.Runtime.CompilerServices;

namespace Photon.SocketServer.Numeric
{
	internal class BigInteger
	{
		private const int maxLength = 70;

		public static readonly int[] primesBelow2000;

		private uint[] data;

		public int dataLength;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger(long value)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger(ulong value)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger(BigInteger bi)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger(string value, int radix)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger(byte[] inData)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger(byte[] inData, int inLen)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger(uint[] inData)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator BigInteger(long value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator BigInteger(ulong value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator BigInteger(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static implicit operator BigInteger(uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator ++(BigInteger bi1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator --(BigInteger bi1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int shiftLeft(uint[] buffer, int shiftVal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int shiftRight(uint[] buffer, int shiftVal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator ~(BigInteger bi1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator -(BigInteger bi1)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object o)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void multiByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void singleByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator &(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator |(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger operator ^(BigInteger bi1, BigInteger bi2)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger max(BigInteger bi)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger min(BigInteger bi)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger abs()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToString(int radix)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string ToHexString()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private BigInteger BarrettReduction(BigInteger x, BigInteger n, BigInteger constant)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger gcd(BigInteger bi)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger GenerateRandom(int bits)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void genRandomBits(int bits, Random rand)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int bitCount()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FermatLittleTest(int confidence)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool RabinMillerTest(int confidence)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SolovayStrassenTest(int confidence)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool LucasStrongTest()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool LucasStrongTestHelper(BigInteger thisVal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool isProbablePrime(int confidence)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool isProbablePrime()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int IntValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public long LongValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int Jacobi(BigInteger a, BigInteger b)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger genPseudoPrime(int bits, int confidence, Random rand)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger genCoPrime(int bits, Random rand)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger modInverse(BigInteger modulus)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] GetBytes()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void setBit(uint bitNum)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void unsetBit(uint bitNum)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BigInteger sqrt()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static BigInteger[] LucasSequence(BigInteger P, BigInteger Q, BigInteger k, BigInteger n)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static BigInteger[] LucasSequenceHelper(BigInteger P, BigInteger Q, BigInteger k, BigInteger n, BigInteger constant, int s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MulDivTest(int rounds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RSATest(int rounds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RSATest2(int rounds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SqrtTest(int rounds)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Main(string[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		static BigInteger()
		{
			throw null;
		}
	}
}
