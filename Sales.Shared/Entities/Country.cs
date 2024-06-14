﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display (Name ="País")]
        [MaxLength(100,ErrorMessage ="El campo {0} debe tener un máximo de {1} caracteres")]
        [Required(ErrorMessage ="El campo {0} es requerido")]

        public string Name { get; set; } = null!;
    }
}
