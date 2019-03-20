using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Input
    {
        public int Id { get; set; }
        public decimal PriceIn { get; set; }
        public string DateIn { get; set; }
        public int AmountIn { get; set; }

        //Relacion Proovedores
        public string ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        //Relacion con almacen
        public virtual ObservableCollection<Store> Stores { get; set; }

    }
}