using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab1.Models
{
    public class Registro
    {
        [Display(Name = "Nombres", Prompt = "Ingresar Nombres")]
        public String? FirstName { get; set; }

        [Display(Name = "Apellidos", Prompt = "Ingresar Apellidos")]
        public String? LastName { get; set; }

        [Display(Name = "Curso")]
        public String? Curso { get; set; }

        public int Id { get; set; }

        public int Creditos { get; set; }
    }
}