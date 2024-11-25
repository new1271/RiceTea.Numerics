using System;
using System.Runtime.CompilerServices;

namespace RiceTea.Numerics
{
    partial struct PackedPrimitive<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool ToBoolean() => (bool)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly char ToChar() => (char)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly sbyte ToSByte() => (sbyte)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly byte ToByte() => (byte)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly short ToInt16() => (short)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort ToUInt16() => (ushort)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int ToInt32() => (int)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint ToUInt32() => (uint)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly long ToInt64() => (long)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong ToUInt64() => (ulong)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly IntPtr ToIntPtr() => (IntPtr)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly UIntPtr ToUIntPtr() => (UIntPtr)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly float ToSingle() => (float)this;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly double ToDouble() => (double)this;

        readonly TypeCode IConvertible.GetTypeCode() => ((IConvertible)_value).GetTypeCode();

        bool IConvertible.ToBoolean(IFormatProvider provider) => provider is null ? ToBoolean() : Convert.ToBoolean(_value, provider);

        char IConvertible.ToChar(IFormatProvider provider) => provider is null ? ToChar() : Convert.ToChar(_value, provider);

        sbyte IConvertible.ToSByte(IFormatProvider provider) => provider is null ? ToSByte() : Convert.ToSByte(_value, provider);

        byte IConvertible.ToByte(IFormatProvider provider) => provider is null ? ToByte() : Convert.ToByte(_value, provider);

        short IConvertible.ToInt16(IFormatProvider provider) => provider is null ? ToInt16() : Convert.ToInt16(_value, provider);

        ushort IConvertible.ToUInt16(IFormatProvider provider) => provider is null ? ToUInt16() : Convert.ToUInt16(_value, provider);

        int IConvertible.ToInt32(IFormatProvider provider) => provider is null ? ToInt32() : Convert.ToInt32(_value, provider);

        uint IConvertible.ToUInt32(IFormatProvider provider) => provider is null ? ToUInt32() : Convert.ToUInt32(_value, provider);

        long IConvertible.ToInt64(IFormatProvider provider) => provider is null ? ToInt64() : Convert.ToInt64(_value, provider);

        ulong IConvertible.ToUInt64(IFormatProvider provider) => provider is null ? ToUInt64() : Convert.ToUInt64(_value, provider);

        float IConvertible.ToSingle(IFormatProvider provider) => provider is null ? ToSingle() : Convert.ToSingle(_value, provider);

        double IConvertible.ToDouble(IFormatProvider provider) => provider is null ? ToDouble() : Convert.ToDouble(_value, provider);

        readonly decimal IConvertible.ToDecimal(IFormatProvider provider) => Convert.ToDecimal(_value, provider);

        readonly DateTime IConvertible.ToDateTime(IFormatProvider provider) => Convert.ToDateTime(_value, provider);

        readonly string IConvertible.ToString(IFormatProvider provider) => provider is null ? _value.ToString() : Convert.ToString(_value, provider);

        readonly object IConvertible.ToType(Type conversionType, IFormatProvider provider) => ((IConvertible)_value).ToType(conversionType, provider);
    }
}
