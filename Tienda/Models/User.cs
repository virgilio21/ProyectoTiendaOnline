using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        //Relacion con la tabla ventas
        //Un usuario puede tener muchas compras, osea puede aparecer en la tabla ventas muchas veces
        public virtual ObservableCollection<Sale> Sales { get; set; }


        //Relacion con Roles
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}