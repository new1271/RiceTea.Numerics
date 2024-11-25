using InlineIL;

using RiceTea.Numerics.Internal;

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RiceTea.Numerics
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PackedPrimitive<T> : IComparable, IConvertible, IComparable<T>, IEquatable<T>, 
        IComparable<PackedPrimitive<T>>, IEquatable<PackedPrimitive<T>> 
        where T : unmanaged
    {
        private static readonly bool _unsigned = PackedPrimitiveHelper.IsUnsignedIntegerType(typeof(T));
        private static readonly bool _floatingPoint = PackedPrimitiveHelper.IsFloatingPointType(typeof(T));
        private static readonly bool _throwException = !PackedPrimitiveHelper.IsPrimitiveType(typeof(T));

        private T _value;

        public T Value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get => _value;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _value = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PackedPrimitive()
        {
            if (_throwException)
                throw new InvalidOperationException(typeof(T).FullName + "is not a primitive type!");
            _value = default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PackedPrimitive(T value) : this()
        {
            _value = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe PackedPrimitive(T* pointer) : this()
        {
            _value = *pointer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(PackedPrimitive<T> other)
        {
            return (int)(this - other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int CompareTo(T other)
        {
            return (int)(this - other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int CompareTo(object obj)
        {
            if (obj is null)
                return -1;
            if (obj is PackedPrimitive<T> packedVal)
                return CompareTo(packedVal);
            if (obj is T val)
                return CompareTo(val);
            return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(PackedPrimitive<T> other)
        {
            return _value.Equals(other._value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool Equals(T other)
        {
            return _value.Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (obj is PackedPrimitive<T> packedVal)
                return Equals(packedVal);
            if (obj is T val)
                return Equals(val);
            return false;
        }

        public override readonly int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override readonly string ToString()
        {
            return _value.ToString();
        }
    }
}
