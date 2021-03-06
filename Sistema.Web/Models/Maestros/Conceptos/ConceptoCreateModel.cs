﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Maestros.Conceptos
{
    public class ConceptoCreateModel
    {
        [Required]
        public string concepto { get; set; }
        [Required]
        public string color { get; set; }
        [Required]
        public string texto { get; set; }
        public string cuentagcom { get; set; }
        [Required]
        public int iduseralta { get; set; }
    }
}
