using System.Runtime.InteropServices;

namespace NMSTools.Framework.Primitives
{
    public static class ByteSlice
    {

    }

    public interface IByteSlice
    {
        int WriteBytes(byte[] bytes, int offset);

        int ReadBytes(byte[] bytes, int offset);

        int Size { get; }
    }
    public interface IByteSlice_16 : IByteSlice
    {
        byte B0 { get; set; }

        byte B1 { get; set; }
    }
    public interface IByteSlice_32 : IByteSlice_16, IByteSlice
    {
        byte B2 { get; set; }

        byte B3 { get; set; }
    }
    public interface IByteSlice_64 : IByteSlice_32, IByteSlice_16, IByteSlice
    {
        byte B4 { get; set; }

        byte B5 { get; set; }

        byte B6 { get; set; }

        byte B7 { get; set; }
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct Short_t : IByteSlice_16
    {
        [FieldOffset(0)]
        public short Value;

        [FieldOffset(0)]
        private byte b1;

        [FieldOffset(1)]
        private byte b0;

        public byte B0 { get => b0; set => b0 = value; }

        public byte B1 { get => b1; set => b1 = value; }

        public int Size => 2;

        private Short_t(short value)
        {
            b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator short(Short_t item) => item.Value;
        public static implicit operator Short_t(short item) => new Short_t(item);

        public static bool operator ==(Short_t left, Short_t right) => left.Value.Equals(right.Value);
        public static bool operator !=(Short_t left, Short_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is Short_t t)
                return Value.Equals(t.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset)
        {
            B0 = bytes[offset];
            B1 = bytes[offset++];

            return offset++;
        }
        public int WriteBytes(byte[] bytes, int offset)
        {
            bytes[offset] = B0;
            bytes[offset++] = B1;

            return offset++;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public struct UShort_t : IByteSlice_16
    {
        [FieldOffset(0)]
        public ushort Value;

        [FieldOffset(0)]
        private byte b1;

        [FieldOffset(1)]
        private byte b0;

        public byte B0 { get => b0; set => b0 = value; }
        public byte B1 { get => b1; set => b1 = value; }

        public int Size => 2;

        public UShort_t(ushort value)
        {
            b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator ushort(UShort_t item) => item.Value;
        public static implicit operator UShort_t(ushort item) => new UShort_t(item);

        public static bool operator ==(UShort_t left, UShort_t right) => left.Value.Equals(right.Value);
        public static bool operator !=(UShort_t left, UShort_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is UShort_t t)
                return Value.Equals(t.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset)
        {
            b0 = bytes[offset];
            b1 = bytes[offset++];

            return offset++;
        }
        public int WriteBytes(byte[] bytes, int offset)
        {
            bytes[offset] = b0;
            bytes[offset++] = b1;

            return offset++;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct Int_t : IByteSlice_32
    {
        [FieldOffset(0)]
        public int Value;

        [FieldOffset(0)]
        private byte b3;

        [FieldOffset(1)]
        private byte b2;

        [FieldOffset(2)]
        private byte b1;

        [FieldOffset(3)]
        private byte b0;

        public byte B0 { get => b0; set => b0 = value; }
        public byte B1 { get => b1; set => b1 = value; }
        public byte B2 { get => b2; set => b2 = value; }
        public byte B3 { get => b3; set => b3 = value; }

        public int Size => 4;

        public Int_t(int value)
        {
            b3 = b2 = b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator int(Int_t item) => item.Value;
        public static implicit operator Int_t(int item) => new Int_t(item);

        public static bool operator ==(Int_t left, Int_t right) => left.Value.Equals(right.Value);
        public static bool operator !=(Int_t left, Int_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is Int_t t)
                return Value.Equals(t.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset)
        {
            b0 = bytes[offset];
            b1 = bytes[offset++];
            b2 = bytes[offset++];
            b3 = bytes[offset++];

            return offset++;
        }
        public int WriteBytes(byte[] bytes, int offset)
        {
            bytes[offset] = b0;
            bytes[offset++] = b1;
            bytes[offset++] = b2;
            bytes[offset++] = b3;

            return offset++;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct UInt_t : IByteSlice_32
    {
        [FieldOffset(0)]
        private uint Value;

        [FieldOffset(0)]
        private byte b3;

        [FieldOffset(1)]
        private byte b2;

        [FieldOffset(2)]
        private byte b1;

        [FieldOffset(3)]
        private byte b0;



        public byte B0 { get => b0; set => b0 = value; }

        public byte B1 { get => b1; set => b1 = value; }

        public byte B2 { get => b2; set => b2 = value; }

        public byte B3 { get => b3; set => b3 = value; }

        public int Size => 4;

        public UInt_t(uint value)
        {
            b3 = b2 = b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator uint(UInt_t item) => item.Value;
        public static implicit operator UInt_t(uint item) => new UInt_t(item);

        public static bool operator ==(UInt_t left, UInt_t right) => left.Value.Equals(right.Value);
        public static bool operator !=(UInt_t left, UInt_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is UInt_t t)
                return Value.Equals(t.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset)
        {
            b0 = bytes[offset];
            b1 = bytes[offset++];
            b2 = bytes[offset++];
            b3 = bytes[offset++];

            return offset++;
        }
        public int WriteBytes(byte[] bytes, int offset)
        {
            bytes[offset] = b0;
            bytes[offset++] = b1;
            bytes[offset++] = b2;
            bytes[offset++] = b3;

            return offset++;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Long_t : IByteSlice_64
    {
        [FieldOffset(0)]
        public long Value;

        [FieldOffset(0)]
        private byte b7;

        [FieldOffset(1)]
        private byte b6;

        [FieldOffset(2)]
        private byte b5;

        [FieldOffset(3)]
        private byte b4;

        [FieldOffset(4)]
        private byte b3;

        [FieldOffset(5)]
        private byte b2;

        [FieldOffset(6)]
        private byte b1;

        [FieldOffset(7)]
        private byte b0;

        public byte B0 { get => b0; set => b0 = value; }
        public byte B1 { get => b1; set => b1 = value; }
        public byte B2 { get => b2; set => b2 = value; }
        public byte B3 { get => b3; set => b3 = value; }
        public byte B4 { get => b4; set => b4 = value; }
        public byte B5 { get => b5; set => b5 = value; }
        public byte B6 { get => b6; set => b6 = value; }
        public byte B7 { get => b7; set => b7 = value; }

        public int Size => 8;

        public Long_t(long value)
        {
            b7 = b6 = b5 = b4 = b3 = b2 = b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator long(Long_t item) => item.Value;
        public static implicit operator Long_t(long item) => new Long_t(item);

        public static bool operator ==(Long_t left, Long_t right) => left.Value.Equals(right.Value);
        public static bool operator !=(Long_t left, Long_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is Long_t t)
                return Value.Equals(t.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset)
        {
            b0 = bytes[offset];
            b1 = bytes[offset++];
            b2 = bytes[offset++];
            b3 = bytes[offset++];
            b4 = bytes[offset++];
            b5 = bytes[offset++];
            b6 = bytes[offset++];
            b7 = bytes[offset++];

            return offset++;
        }
        public int WriteBytes(byte[] bytes, int offset)
        {
            bytes[offset] = b0;
            bytes[offset++] = b1;
            bytes[offset++] = b2;
            bytes[offset++] = b3;
            bytes[offset++] = b4;
            bytes[offset++] = b5;
            bytes[offset++] = b6;
            bytes[offset++] = b7;

            return offset++;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct ULong_t : IByteSlice_64
    {
        [FieldOffset(0)]
        public ulong Value;

        [FieldOffset(0)]
        private byte b7;

        [FieldOffset(1)]
        private byte b6;

        [FieldOffset(2)]
        private byte b5;

        [FieldOffset(3)]
        private byte b4;

        [FieldOffset(4)]
        private byte b3;

        [FieldOffset(5)]
        private byte b2;

        [FieldOffset(6)]
        private byte b1;

        [FieldOffset(7)]
        private byte b0;

        public byte B0 { get => b0; set => b0 = value; }
        public byte B1 { get => b1; set => b1 = value; }
        public byte B2 { get => b2; set => b2 = value; }
        public byte B3 { get => b3; set => b3 = value; }
        public byte B4 { get => b4; set => b4 = value; }
        public byte B5 { get => b5; set => b5 = value; }
        public byte B6 { get => b6; set => b6 = value; }
        public byte B7 { get => b7; set => b7 = value; }

        public int Size => 8;

        public ULong_t(ulong value)
        {
            b7 = b6 = b5 = b4 = b3 = b2 = b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator ulong(ULong_t item) => item.Value;
        public static implicit operator ULong_t(ulong item) => new ULong_t(item);

        public static bool operator ==(ULong_t left, ULong_t right) => left.Value.Equals(right.Value);
        public static bool operator !=(ULong_t left, ULong_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is ULong_t t)
                return Value.Equals(t.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset)
        {
            b0 = bytes[offset];
            b1 = bytes[offset++];
            b2 = bytes[offset++];
            b3 = bytes[offset++];
            b4 = bytes[offset++];
            b5 = bytes[offset++];
            b6 = bytes[offset++];
            b7 = bytes[offset++];

            return offset++;
        }
        public int WriteBytes(byte[] bytes, int offset)
        {
            bytes[offset] = b0;
            bytes[offset++] = b1;
            bytes[offset++] = b2;
            bytes[offset++] = b3;
            bytes[offset++] = b4;
            bytes[offset++] = b5;
            bytes[offset++] = b6;
            bytes[offset++] = b7;

            return offset++;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct Float_t : IByteSlice_32
    {
        [FieldOffset(0)]
        public float Value;

        [FieldOffset(0)]
        private byte b3;

        [FieldOffset(1)]
        private byte b2;

        [FieldOffset(2)]
        private byte b1;

        [FieldOffset(3)]
        private byte b0;

        public byte B0 { get => b0; set => b0 = value; }
        public byte B1 { get => b1; set => b1 = value; }
        public byte B2 { get => b2; set => b2 = value; }
        public byte B3 { get => b3; set => b3 = value; }

        public int Size => 4;

        public Float_t(float value)
        {
            b3 = b2 = b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator float(Float_t item) => item.Value;
        public static implicit operator Float_t(float item) => new Float_t(item);

        public static bool operator ==(Float_t left, Float_t right) => left.Value.Equals(right.Value);
        public static bool operator !=(Float_t left, Float_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();
        public override bool Equals(object obj)
        {
            if (obj is Float_t t)
                return Value.Equals(t.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset)
        {
            b0 = bytes[offset];
            b1 = bytes[offset++];
            b2 = bytes[offset++];
            b3 = bytes[offset++];

            return offset++;
        }
        public int WriteBytes(byte[] bytes, int offset)
        {
            bytes[offset] = b0;
            bytes[offset++] = b1;
            bytes[offset++] = b2;
            bytes[offset++] = b3;

            return offset++;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Double_t : IByteSlice_64
    {
        [FieldOffset(0)]
        public double Value;

        [FieldOffset(0)]
        private byte b7;

        [FieldOffset(1)]
        private byte b6;

        [FieldOffset(2)]
        private byte b5;

        [FieldOffset(3)]
        private byte b4;

        [FieldOffset(4)]
        private byte b3;

        [FieldOffset(5)]
        private byte b2;

        [FieldOffset(6)]
        private byte b1;

        [FieldOffset(7)]
        private byte b0;

        public byte B0 { get => b0; set => b0 = value; }
        public byte B1 { get => b1; set => b1 = value; }
        public byte B2 { get => b2; set => b2 = value; }
        public byte B3 { get => b3; set => b3 = value; }
        public byte B4 { get => b4; set => b4 = value; }
        public byte B5 { get => b5; set => b5 = value; }
        public byte B6 { get => b6; set => b6 = value; }
        public byte B7 { get => b7; set => b7 = value; }

        public int Size => 8;

        public Double_t(double value)
        {
            b7 = b6 = b5 = b4 = b3 = b2 = b1 = b0 = 0;
            Value = value;
        }

        public static implicit operator double(Double_t item) => item.Value;
        public static implicit operator Double_t(double item) => new Double_t(item);

        public static bool operator ==(Double_t left, Double_t right) => left.Value.Equals(right.Value);

        public static bool operator !=(Double_t left, Double_t right) => !(left.Value == right.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override bool Equals(object obj)
        {
            if (obj is Double_t i)
                return Value.Equals(i.Value);

            return false;
        }

        public int ReadBytes(byte[] bytes, int offset = 0)
        {
            b0 = bytes[offset];
            b1 = bytes[offset++];
            b2 = bytes[offset++];
            b3 = bytes[offset++];
            b4 = bytes[offset++];
            b5 = bytes[offset++];
            b6 = bytes[offset++];
            b7 = bytes[offset++];

            return offset++;
        }

        public int WriteBytes(byte[] bytes, int offset = 0)
        {
            bytes[offset] = b0;
            bytes[offset++] = b1;
            bytes[offset++] = b2;
            bytes[offset++] = b3;
            bytes[offset++] = b4;
            bytes[offset++] = b5;
            bytes[offset++] = b6;
            bytes[offset++] = b7;

            return offset++;
        }
    }
}
