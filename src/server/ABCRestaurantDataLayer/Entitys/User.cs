﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABCRestaurantDataLayer.Entitys
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
    }
}
