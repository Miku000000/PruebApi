using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaData.DataBase.Tables
{
    [Table("Personas")]
    public class Persona
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(30)]
        public string nombres { get; set; }
        [Required]
        [StringLength(30)]
        public string apellidoPaterno { get; set; }
        [Required]
        [StringLength(30)]
        public string apellidoMaterno { get; set; }
        [Required]
        [StringLength(30)]
        public string correo { get; set; }
        [Required]
        [StringLength(9)]
        public string telefonoMovil { get; set; }
        [Required]
        [StringLength(8)]
        public string dni { get; set; }
    }
}
