using Project_Eticaret.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Eticaret.MODEL.Entities
{
    public class SubCategory:CoreEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Tag { get; set; }
        public Guid CategoryID { get; set; }

        //bir alt kategorinin bir kategorisi olur.
        public virtual Category Category { get; set; }
        //bir alt kategorinin içerisinde birden fazla ürünü olabilir.
        public virtual List<Product> Products { get; set; }
    }
}
