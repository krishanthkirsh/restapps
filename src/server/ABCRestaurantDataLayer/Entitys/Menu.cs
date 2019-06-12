using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCRestaurant_Data.Entitys
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public string MenuDescription { get; set; }
        public int Unit { get; set; }
        public double Price { get; set; }
    }
}
