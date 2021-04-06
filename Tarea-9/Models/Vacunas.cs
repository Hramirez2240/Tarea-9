using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Tarea_9.Models
{
    public partial class Vacunas
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public string TipoDeSangre { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public bool? LeHaDadoCovid { get; set; }
        public string Justifique { get; set; }
    }
}
