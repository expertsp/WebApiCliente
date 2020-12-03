using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCliente.Domain.Entities
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Nome do cliente é obrigatório ser informado.")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [Range(1,200, ErrorMessage = "A idade não foi informada ou esta incorreta.")]
        public int Idade { get; set; }
    }
}
