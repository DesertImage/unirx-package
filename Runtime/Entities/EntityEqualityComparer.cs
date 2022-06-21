using System.Collections.Generic;
using DesertImage.ECS;

namespace Entities
{
    public interface IEntityComparer : IEqualityComparer<IEntity>
    {
    }

    public class EntityEqualityComparer : IEntityComparer
    {
        public bool Equals(IEntity x, IEntity y)
        {
            if (x == null || y == null) return false;

            return x.Id == y.Id;
        }

        public int GetHashCode(IEntity obj)
        {
            return obj.Id;
        }
    }
}