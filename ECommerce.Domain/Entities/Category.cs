﻿using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Category:Entity
    {
        public string CategoryName { get; set; }
        public Product Product { get; set; }
        public Brand Brand { get; set; }
    }
}



