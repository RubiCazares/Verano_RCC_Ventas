﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Categorías")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un máximo de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es requerido")]

        public string Name { get; set; } = null!;

        //public ICollection<State>? States { get; set; }

        //public int StatesNumber => States == null ? 0 : States.Count;
    }
}
