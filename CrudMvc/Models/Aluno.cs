using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudMvc.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime Nascimento { get; set; }

        public bool Ativo { get; set; }
    }
}