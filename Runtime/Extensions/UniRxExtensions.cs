using System.Collections.Generic;
using System.Linq;
using UniRx;

namespace DesertImage.Extensions
{
    public static class UniRxExtensions
    {
        public static ReactiveCollection<T> ShuffleListToReactive<T>(this IEnumerable<T> array)
        {
            var rnd = new System.Random();

            return array.OrderBy(x => rnd.Next()).ToReactiveCollection();
        }
    }
}