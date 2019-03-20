using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Role
    {
        public int Id { get; set; }
        public bool IsRole { get; set; }
        public string Description { get; set; }


        //Relacion con User
        public virtual ObservableCollection<User> Users { get; set; }

    }
}