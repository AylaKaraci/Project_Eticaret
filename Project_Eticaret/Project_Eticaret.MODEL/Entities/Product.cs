﻿using Project_Eticaret.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project_Eticaret.MODEL.Entities
{
   public class Product: CoreEntity
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public decimal? Price { get; set; }
        public short? UnitsInStock { get; set; }
        public string Quantity { get; set; }//birim miktar-kg,adet vs
        public Guid SubCategoryID { get; set; }

        //1 ürün 1 alt kategoriye ait olur.
        public virtual SubCategory SubCategory { get; set; }

        //1 ürün birden fazla sipariş detayınında bulunabilir.
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
