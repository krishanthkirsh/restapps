using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCRestaurantDataLayer.Entitys
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public virtual Menu MenuItem { get; set; }
        public virtual User LoginUser { get; set; }
    }
}
