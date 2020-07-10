using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class SucursalsViewModel
    {
        public SucursalsViewModel()
        {

        }
        public SelectList FarmaciesList { get; set; }

        [Required(ErrorMessage = "Seleccione al menos una opcion")]
        public int? FarmaciesId { get; set; }

        public Farmacies Frarmacies { get; set; }

        public int Id { get; set; }

        public string Adresss1 { get; set; }

        public string Adresss2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Departamento { get; set; }

        public string Phone { get; set; }

        public string ContactName { get; set; }

        public int? StoreId { get; set; }


    }
}