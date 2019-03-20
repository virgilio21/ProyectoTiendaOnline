using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Provider
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Direction { get; set; }
        public string Phone { get; set; }

        //Relacion con Entradas
        public virtual ObservableCollection<Input> Inputs { get; set; }
    }
}