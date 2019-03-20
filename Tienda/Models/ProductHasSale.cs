using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class ProductHasSale
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }


    }
}