using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sucursal
    {
        public int Id { get; set; }

        public string Adresss1 { get; set; }

        public string Adresss2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Departamento { get; set; }

        public string Phone { get; set; }

        public string ContactName { get; set; }

        public int? StoreId { get; set; } //identificador de sucursales
    }
}