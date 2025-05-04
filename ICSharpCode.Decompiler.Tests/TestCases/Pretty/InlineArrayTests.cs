using System.Runtime.CompilerServices;

namespace ICSharpCode.Decompiler.Tests.TestCases.Pretty
{
	public class InlineArrayTests
	{
		[InlineArray(16)]
		public struct Byte16
		{
			private byte elem;
		}

		[InlineArray(4)]
		public struct Int128
		{
			private int elem;
		}

		public byte Byte0()
		{
			return GetByte16()[0];
		}

		public byte Byte5()
		{
			return GetByte16()[5];
		}

		public byte ByteN()
		{
			return GetByte16()[GetIndex()];
		}

		public byte ByteN2()
		{
			return GetByte16()[GetIndex()];
		}

		public byte Byte0(Byte16 array, byte value)
		{
			return array[0] = value;
		}

		public byte Byte5(Byte16 array, byte value)
		{
			return array[5] = value;
		}

		public byte ByteN(Byte16 array, byte value)
		{
			return array[GetIndex()] = value;
		}

		public byte VariableSplitting(Byte16 array, byte value)
		{
			return array[GetIndex()] = (array[GetIndex() + 1] = value);
		}

		public Byte16 GetByte16()
		{
			return default(Byte16);
		}

		public int GetIndex()
		{
			return 0;
		}
	}
}
