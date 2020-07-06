using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("farmacies")]
    public class Farmacies
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Sucursal> Sucursals { get; set; }


    }
}