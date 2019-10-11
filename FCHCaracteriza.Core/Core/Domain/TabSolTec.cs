using System;
using System.Collections.Generic;

namespace FCHCaracteriza.Core.Core.Domain
{
    public partial class TabSolTec
    {
        public string RutEmp { get; set; }
        public string CodSol { get; set; }
        public string Nombre { get; set; }
        public DateTime? FecInicio { get; set; }
        public DateTime? FecTermino { get; set; }
        public string CodResp { get; set; }
        public string Descrip { get; set; }
        public string Beneficio { get; set; }
        public string TipoEspec { get; set; }
        public string TecnAlternativa { get; set; }
        public string PptaValor { get; set; }
        public string ModeloNeg { get; set; }
        public string TipoModeloNeg { get; set; }
        public string Kpi { get; set; }
        public string Patentado { get; set; }
        public string TipoProceso { get; set; }
        public string TipoOrigen { get; set; }
        public string CapHum { get; set; }
        public string SolucSimil { get; set; }
        public string Lugar { get; set; }
        public string OtraAplic { get; set; }
        public string RecomendTecn { get; set; }
        public string CodUsuario { get; set; }
        public DateTime? FecIng { get; set; }
        public string Ambito { get; set; }
        public string Resolucion { get; set; }
        public string TipoCadVal { get; set; }
        public string TipoFoco { get; set; }
        public string TipoMadurez { get; set; }
        public string RutUsuario { get; set; }
        public string Replicable { get; set; }
        public string Escalable { get; set; }
        public string TendenciaTecnologica { get; set; }
        public string PropiedadIntel { get; set; }
        public string Pais { get; set; }
        public string Nucleo { get; set; }
        public string Innovacion { get; set; }
        public string PrincipalesComp { get; set; }
        public string ElementoDife { get; set; }
        public string LugarComp { get; set; }
        public string Recomendaciones { get; set; }
    }
}
