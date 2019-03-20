using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public decimal PriceTotal { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }


        //Una venta solo pertenece a un usuario
        public int UserId { get; set; }
        public virtual User User { get; set; }

        //Relacion con la tabla salidas
        public int OutputId { get; set; }
        public virtual Output Output { get; set; }

        //Relacion muchos a muchos
        public virtual ObservableCollection<ProductHasSale> ProductHasSales { get; set; }

    }
}