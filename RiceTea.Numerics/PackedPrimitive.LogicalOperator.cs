using InlineIL;

using System.Runtime.CompilerServices;

namespace RiceTea.Numerics
{
    partial struct PackedPrimitive<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.Ceq();
            return IL.Return<bool>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.Ceq();
            IL.Push(0);
            IL.Emit.Ceq();
            return IL.Return<bool>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator >(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            if (_unsigned)
            {
                IL.Push(a._value);
                IL.Push(b._value);
                IL.Emit.Cgt_Un();
                return IL.Return<bool>();
            }
            else
            {
                IL.Push(a._value);
                IL.Push(b._value);
                IL.Emit.Cgt();
                return IL.Return<bool>();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator <(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            if (_unsigned)
            {
                IL.Push(a._value);
                IL.Push(b._value);
                IL.Emit.Clt_Un();
                return IL.Return<bool>();
            }
            else
            {
                IL.Push(a._value);
                IL.Push(b._value);
                IL.Emit.Clt();
                return IL.Return<bool>();
            }
        }
    }
}
