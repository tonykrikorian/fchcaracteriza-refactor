using System;
using System.Collections.Generic;

namespace FCHCaracteriza.Core.Core.Domain
{
    public partial class TabEmpresa
    {
        public string RutEmp { get; set; }
        public string RazonSocial { get; set; }
        public string Nombre { get; set; }
        public string DescripcionEmpresa { get; set; }
        public DateTime? FecIniAct { get; set; }
        public string SitioWeb { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Pais { get; set; }
        public string Region { get; set; }
        public string Ciudad { get; set; }
        public string Fono { get; set; }
        public string Cluster { get; set; }
        public string Recomendada { get; set; }
        public string DescripRecom { get; set; }
        public string TipoEje { get; set; }
        public string LinkBrechas { get; set; }
        public string CodUsuario { get; set; }
        public DateTime? FecIng { get; set; }
        public string Ambito { get; set; }
        public string TipoEmpresa { get; set; }
        public short? Dotacion { get; set; }
        public int? Venta { get; set; }
        public string TipoInfra { get; set; }
        public string Vinculaciones { get; set; }
        public string DescripVinculacion { get; set; }
        public string Otro { get; set; }
        public string Archivo { get; set; }
        public string ArchivoOri { get; set; }
        public string DescArchivo { get; set; }
        public string RutUsuario { get; set; }
        public string Origen { get; set; }
        public string CapacidadDoc { get; set; }
        public string CapacidadMag { get; set; }
        public string CapacidadPro { get; set; }
        public string CapacidadTec { get; set; }
        public string Especialidad { get; set; }
    }
}
