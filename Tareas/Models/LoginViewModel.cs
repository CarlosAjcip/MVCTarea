﻿using System.ComponentModel.DataAnnotations;

namespace Tareas.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El campo deber ser un correro electronico valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El  campo {0} es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Recuerdame")]
        public bool Recuerdame { get; set; }
    }
}
