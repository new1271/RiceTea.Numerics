using InlineMethod;

using System;

namespace RiceTea.Numerics.Internal
{
    internal static class PackedPrimitiveHelper
    {
        [Inline(InlineBehavior.Remove)]
        public static bool IsUnsignedIntegerType(Type type)
        {
            return type == typeof(bool) || type == typeof(byte) ||
                type == typeof(char) || type == typeof(ushort) ||
                type == typeof(uint) || type == typeof(ulong);
        }

        [Inline(InlineBehavior.Remove)]
        public static bool IsSignedIntegerType(Type type)
        {
            return type == typeof(sbyte) || type == typeof(short) ||
                type == typeof(int) || type == typeof(long);
        }

        [Inline(InlineBehavior.Remove)]
        public static bool IsFloatingPointType(Type type)
        {
            return type == typeof(float) || type == typeof(double);
        }

        [Inline(InlineBehavior.Remove)]
        public static bool IsPrimitiveType(Type type)
        {
            return IsUnsignedIntegerType(type) || IsSignedIntegerType(type) || IsFloatingPointType(type);
        }
    }
}
