using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    internal class TankCollectionInfo : IEquatable<TankCollectionInfo>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        
        public TankCollectionInfo(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public bool Equals(TankCollectionInfo? other)
        {
            if (other == null || Name == null || other.Name == null) return false;
            if (Name == other?.Name) return true;
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }
    }
}