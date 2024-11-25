using InlineIL;

using RiceTea.Numerics.Internal;

using System;
using System.Runtime.CompilerServices;

namespace RiceTea.Numerics
{
    partial struct PackedPrimitive<T>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator |(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            if (_floatingPoint)
                throw new InvalidOperationException(typeof(T).FullName + " cannot do 'Or' operation");
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.Or();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator &(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            if (_floatingPoint)
                throw new InvalidOperationException(typeof(T).FullName + " cannot do 'And' operation");
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.And();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator ^(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            if (_floatingPoint)
                throw new InvalidOperationException(typeof(T).FullName + " cannot do 'Xor' operation");
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.Xor();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator ~(PackedPrimitive<T> a)
        {
            if (_floatingPoint)
                throw new InvalidOperationException(typeof(T).FullName + " cannot do 'Not' operation");
            IL.Push(a._value);
            IL.Emit.Not();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator <<(PackedPrimitive<T> _base, int value)
        {
            IL.Push(_base._value);
            IL.Push(value);
            IL.Emit.Shl();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator >>(PackedPrimitive<T> _base, int value)
        {
            if (_unsigned)
            {
                IL.Push(_base._value);
                IL.Push(value);
                IL.Emit.Shr_Un();
                IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
                return IL.Return<PackedPrimitive<T>>();
            }
            else
            {
                IL.Push(_base._value);
                IL.Push(value);
                IL.Emit.Shr();
                IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
                return IL.Return<PackedPrimitive<T>>();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator +(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.Add();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator -(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.Sub();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator *(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            IL.Push(a._value);
            IL.Push(b._value);
            IL.Emit.Mul();
            IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
            return IL.Return<PackedPrimitive<T>>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static PackedPrimitive<T> operator /(PackedPrimitive<T> a, PackedPrimitive<T> b)
        {
            if (_unsigned)
            {
                IL.Push(a._value);
                IL.Push(b._value);
                IL.Emit.Div_Un();
                IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
                return IL.Return<PackedPrimitive<T>>();
            }
            else
            {
                IL.Push(a._value);
                IL.Push(b._value);
                IL.Emit.Div();
                IL.Emit.Newobj(MethodRef.Constructor(typeof(PackedPrimitive<T>), typeof(T)));
                return IL.Return<PackedPrimitive<T>>();
            }
        }
    }
}
