﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Motion
{
    public class ProveedormotionCreateModel
    {
        [Required]
        public int idproyecto { get; set; }
        [Required]
        public int iditem { get; set; }
        [Required]
        public int? idsubitem { get; set; }
        public int idproveedor { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal tarifadiaria { get; set; }
        [Required]
        public int iduseralta { get; set; }
        [Required]
        public DateTime fecalta { get; set; }
        [Required]
        public int iduserumod { get; set; }
        [Required]
        public DateTime fecumod { get; set; }
        [Required]
        public bool activo { get; set; }
    }
}
