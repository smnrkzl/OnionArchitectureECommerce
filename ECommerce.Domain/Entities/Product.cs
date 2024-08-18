﻿using ECommerce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public  class Product:Entity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
