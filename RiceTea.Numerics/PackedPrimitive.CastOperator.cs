using InlineIL;

using System;
using System.Runtime.CompilerServices;

namespace RiceTea.Numerics
{
    partial struct PackedPrimitive<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PackedPrimitive<T>(T primitive)
        {
            return new PackedPrimitive<T>(primitive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe explicit operator PackedPrimitive<T>(T* pointer)
        {
            return new PackedPrimitive<T>(*pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator bool(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Push(default(T));
            IL.Emit.Ceq();
            IL.Emit.Not();
            return IL.Return<bool>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_U1();
            return IL.Return<byte>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator sbyte(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_I1();
            return IL.Return<sbyte>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator char(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_U2();
            return IL.Return<char>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_I2();
            return IL.Return<short>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ushort(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_U2();
            return IL.Return<ushort>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_I4();
            return IL.Return<int>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_U4();
            return IL.Return<uint>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator long(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_I8();
            return IL.Return<long>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator ulong(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_U8();
            return IL.Return<ulong>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float(PackedPrimitive<T> value)
        {
            if (_unsigned)
            {
                IL.Push(value._value);
                IL.Emit.Conv_R_Un();
                return IL.Return<float>();
            }
            else
            {
                IL.Push(value._value);
                IL.Emit.Conv_R4();
                return IL.Return<float>();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double(PackedPrimitive<T> value)
        {
            IL.Push(value._value);
            IL.Emit.Conv_R8();
            return IL.Return<double>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator IntPtr(PackedPrimitive<T> value)
        {
            if (_floatingPoint)
                throw new InvalidCastException();
            IL.Push(value._value);
            IL.Emit.Conv_I();
            return IL.Return<IntPtr>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UIntPtr(PackedPrimitive<T> value)
        {
            if (_floatingPoint)
                throw new InvalidCastException();
            IL.Push(value._value);
            IL.Emit.Conv_U();
            return IL.Return<UIntPtr>();
        }
    }
}
