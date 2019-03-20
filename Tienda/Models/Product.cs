using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string DescriptionProduct { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        //Genero
        public string Gender { get; set; }

        public virtual ObservableCollection<ProductHasStore> ProductHasStores { get; set; }
        public virtual ObservableCollection<ProductHasSale> ProductHasSales { get; set; }
    }
}