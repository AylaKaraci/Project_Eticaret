﻿using Project_Eticaret.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Eticaret.MODEL.Entities
{
    public class OrderDetail: CoreEntity
    {
        public Guid ProductID { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? Quantity { get; set; }

        //bir sipariş detayında bir ürün olabilir
        public virtual Product Product { get; set; }
        //bir sipariş detayı bir order a ait olur
        public virtual Order Order { get; set; }

    }
}
