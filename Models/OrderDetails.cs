using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Shopping_Store.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [Display(Name="Order")]
        public int OrderId { get; set; }
        [Display(Name="Product")]
        public int ProductId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("ProductId")]
        public Products Products { get; set; }

    }
}
