using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaData.DataBase.Tables
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Required]
        [StringLength(50)]
        public string Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int id_Persona { get; set; }
    }
}
