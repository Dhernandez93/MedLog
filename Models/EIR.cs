using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MedLog.Models
{
    public class EIR
    {
        [Key]
        public string eir { get; set; }

        public string contenedor { get; set; }

        public string sello { get; set; }

        public string empresa_nombre { get; set; }

        public string responsable_nombre { get; set; }
    }
}
