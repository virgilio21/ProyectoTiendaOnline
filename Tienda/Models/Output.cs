using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Output
    {
        public int Id { get; set; }
        public decimal PriceOut { get; set; }
        public string DateOut { get; set; }
        public int AmountOut { get; set; }

        //un registro de una salida puede corresponder a una venta en la cual se venden muchos productos
        public virtual ObservableCollection<Sale> Sales { get; set; }


        //Relacion con alamacen
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }

    }
}