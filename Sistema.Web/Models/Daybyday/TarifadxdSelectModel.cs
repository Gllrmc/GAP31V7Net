﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Web.Models.Daybyday
{
    public class TarifadxdSelectModel
    {
        public int idtarifadxd { get; set; }
        public int idproyecto { get; set; }
        public string proyectoorden { get; set; }
        public string proyecto { get; set; }
        public int iditem { get; set; }
        public string itemorden { get; set; }
        public string itemes { get; set; }
        public string itemen { get; set; }
        public int idsica { get; set; }
        public string cargosica { get; set; }
        public decimal bruto8hs { get; set; }
        public decimal extra4hs { get; set; }
        public decimal bruto12hs { get; set; }
    }
}
