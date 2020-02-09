using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace PathfinderBuissness.Model.Capital
{
    public abstract class CapitalBase : IEquatable<CapitalBase>
    {
        public int Quantity { get; set; } = 0;

        public CapitalBase(int quantity)
        {
            Quantity = quantity;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as CapitalBase);
        }

        public bool Equals([AllowNull] CapitalBase other)
        {
            return other != null &&
                   Quantity == other.Quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Quantity);
        }

        public static bool operator ==(CapitalBase left, CapitalBase right)
        {
            return EqualityComparer<CapitalBase>.Default.Equals(left, right);
        }

        public static bool operator !=(CapitalBase left, CapitalBase right)
        {
            return !(left == right);
        }
    }
}
