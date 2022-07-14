using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCRUD.DAL.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order? Order { get; set; }
        public string? Name { get; set; }
        public decimal Quantity { get; set; }
        public string? Unit { get; set; }

    }
}
