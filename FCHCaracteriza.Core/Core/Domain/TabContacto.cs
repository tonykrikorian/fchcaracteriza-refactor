using System;
using System.Collections.Generic;

namespace FCHCaracteriza.Core.Core.Domain
{
    public partial class TabContacto
    {
        public string RutEmp { get; set; }
        public string RutContacto { get; set; }
        public string Origen { get; set; }
        public string TipoEmpresa { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoContacto { get; set; }
        public string Cargo { get; set; }
        public string Mail { get; set; }
        public string Fono { get; set; }
        public string Celular { get; set; }
        public string CodUsuario { get; set; }
        public DateTime? FecIng { get; set; }
        public string Ambito { get; set; }
        public decimal Id { get; set; }
    }
}
