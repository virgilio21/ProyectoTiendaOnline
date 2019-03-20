using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Store
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public decimal PriceStore { get; set; }


        //Relacion con la tabla entradas
        public int InputId { get; set; }
        public virtual Input Input{ get; set; }

        //Relacion con salidas
        public virtual ObservableCollection<Output> Outputs { get; set; }



        //Relacion con la tabla mucho a muchos
        public virtual ObservableCollection<ProductHasStore> ProductHasStores { get; set; }



    }
}