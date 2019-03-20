using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class ProductHasStore
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }


        public virtual Store Stores { get; set; }
        public virtual Product Products { get; set; }
    }
}