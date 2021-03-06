﻿

using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Web.Models.Maestros.Clientes
{
    public class ClienteCreateModel
    {
        public int? idpersona { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La razon social no puede ser mayor a {1} ni menor a {2} caracteres")]
        public string razonsocial { get; set; }
        [Required]
        public string cuit { get; set; }
        [Required]
        public string situacioniva { get; set; }
        [Required]
        public string situacioniibb { get; set; }
        public string jurisdiccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string cpostal { get; set; }
        [Required]
        public int idprovincia { get; set; }
        [Required]
        public int idpais { get; set; }
        public string formadepago { get; set; }
        [Required]
        public int iduseralta { get; set; }
        [Required]
        public DateTime fecalta { get; set; }
        [Required]
        public int iduserumod { get; set; }
        [Required]
        public DateTime fecumod { get; set; }
        public bool activo { get; set; }
    }
}
