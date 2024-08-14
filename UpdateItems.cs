using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class OrderItem
    {
        public string Sku { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }

    public class OrderItemMovement
    {
        public string Sku { get; set; }

        public int Order { get; set; }
    }

    class ValueComparer : IComparer<OrderItem>
    {
        public int Compare(OrderItem x, OrderItem y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x == null) return -1;
            if (y == null) return 1;

            return x.Order == y.Order ? 0 :
                     x.Order > y.Order ? 1 : -1;
        }
    }

    internal class UpdateItems
    {
        public static OrderItem? GetByBinarySearchSku(string sku, OrderItem[] items)
        {
            return items.FirstOrDefault(it => it.Sku == sku);
        }

        public static IEnumerable<OrderItemMovement> ReeangeItems(OrderItem[] items, OrderItem[] movements)
        {
            var result = new Dictionary<string, OrderItemMovement>();
            var itemsSorted = items.OrderBy(it => it.Order).ToList();

            foreach (var item in movements)
            {
                var itemIndex = itemsSorted.BinarySearch(item, new ValueComparer());

                if (itemIndex == -1)
                {
                    AsignMovement(result, item);
                    continue;
                }

                var itemToChange = itemsSorted[itemIndex];
                var source = GetByBinarySearchSku(item.Sku, items);

                if (itemToChange != null && source != null)
                {
                    (itemToChange.Order, source.Order) = (source.Order, itemToChange.Order);
                    AsignMovement(result, source);
                    AsignMovement(result, itemToChange);
                }

            }

            return result.Values.ToArray();
        }

        private static void AsignMovement(Dictionary<string, OrderItemMovement> result, OrderItem? source)
        {
            if (source == null)
            {
                return;
            }

            if (result.TryGetValue(source.Sku, out var valueSource))
            {
                valueSource.Order = source.Order;
            }
            else
            {
                result.Add(source.Sku, new OrderItemMovement { Order = source.Order, Sku = source.Sku });
            }
        }
    }
}
