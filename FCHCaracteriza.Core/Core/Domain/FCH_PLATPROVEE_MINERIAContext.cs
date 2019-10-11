using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace FCHCaracteriza.Core.Core.Domain
{
    public partial class FCH_PLATPROVEE_MINERIAContext : DbContext
    {
        private IConfiguration _configuration;
        private IDbConnection _sqlConnection;

        public FCH_PLATPROVEE_MINERIAContext()
        {
        }

        public FCH_PLATPROVEE_MINERIAContext(DbContextOptions<FCH_PLATPROVEE_MINERIAContext> options,IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
            _sqlConnection = new SqlConnection(_configuration.GetConnectionString("QA"));
        }

        public virtual DbSet<TabContacto> TabContacto { get; set; }
        public virtual DbSet<TabEmpresa> TabEmpresa { get; set; }
        public virtual DbSet<TabSolTec> TabSolTec { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                //optionsBuilder.UseSqlServer("Server=LAPTOP-LPL11K6G\\SQLEXPRESS;Database=FCH_PLATPROVEE_MINERIA;User Id=sa;Password=Guitar100%$;MultipleActiveResultSets=True;Connection Timeout=120;");
                optionsBuilder.UseSqlServer(_sqlConnection.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TabContacto>(entity =>
            {
                entity.ToTable("TAB_CONTACTO");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ambito)
                    .HasColumnName("ambito")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasColumnName("celular")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("cod_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecIng)
                    .HasColumnName("fec_ing")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fono)
                    .HasColumnName("fono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("origen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutContacto)
                    .IsRequired()
                    .HasColumnName("rut_contacto")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RutEmp)
                    .IsRequired()
                    .HasColumnName("rut_emp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoContacto)
                    .HasColumnName("tipo_contacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmpresa)
                    .HasColumnName("tipo_empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabEmpresa>(entity =>
            {
                entity.HasKey(e => e.RutEmp)
                    .HasName("PK_TAB_EMPRESA_1");

                entity.ToTable("TAB_EMPRESA");

                entity.Property(e => e.RutEmp)
                    .HasColumnName("rut_emp")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ambito)
                    .HasColumnName("ambito")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Archivo)
                    .HasColumnName("archivo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ArchivoOri)
                    .HasColumnName("archivo_ori")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadDoc)
                    .HasColumnName("capacidad_doc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadMag)
                    .HasColumnName("capacidad_mag")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadPro)
                    .HasColumnName("capacidad_pro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CapacidadTec)
                    .HasColumnName("capacidad_tec")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cluster)
                    .HasColumnName("cluster")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("cod_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("correo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescArchivo)
                    .HasColumnName("desc_archivo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescripRecom)
                    .HasColumnName("descrip_recom")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescripVinculacion)
                    .HasColumnName("descrip_vinculacion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionEmpresa)
                    .HasColumnName("descripcion_empresa")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dotacion).HasColumnName("dotacion");

                entity.Property(e => e.Especialidad)
                    .HasColumnName("especialidad")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FecIng)
                    .HasColumnName("fec_ing")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecIniAct)
                    .HasColumnName("fec_ini_act")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fono)
                    .HasColumnName("fono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkBrechas)
                    .HasColumnName("link_brechas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasColumnName("origen")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Otro)
                    .HasColumnName("otro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recomendada)
                    .HasColumnName("recomendada")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RutUsuario)
                    .HasColumnName("rut_usuario")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SitioWeb)
                    .HasColumnName("sitio_web")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEje)
                    .HasColumnName("tipo_eje")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmpresa)
                    .IsRequired()
                    .HasColumnName("tipo_empresa")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInfra)
                    .HasColumnName("tipo_infra")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Venta).HasColumnName("venta");

                entity.Property(e => e.Vinculaciones)
                    .HasColumnName("vinculaciones")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TabSolTec>(entity =>
            {
                entity.HasKey(e => e.CodSol)
                    .HasName("PK_SOL_TEC");

                entity.ToTable("TAB_SOL_TEC");

                entity.Property(e => e.CodSol)
                    .HasColumnName("cod_sol")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ambito)
                    .HasColumnName("ambito")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Beneficio)
                    .HasColumnName("beneficio")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CapHum)
                    .HasColumnName("cap_hum")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodResp)
                    .HasColumnName("cod_resp")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodUsuario)
                    .HasColumnName("cod_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descrip)
                    .HasColumnName("descrip")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ElementoDife)
                    .HasColumnName("elemento_dife")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Escalable)
                    .HasColumnName("escalable")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecIng)
                    .HasColumnName("fec_ing")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecInicio)
                    .HasColumnName("fec_inicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecTermino)
                    .HasColumnName("fec_termino")
                    .HasColumnType("datetime");

                entity.Property(e => e.Innovacion)
                    .HasColumnName("innovacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kpi)
                    .HasColumnName("kpi")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Lugar)
                    .HasColumnName("lugar")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LugarComp)
                    .HasColumnName("lugar_comp")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloNeg)
                    .HasColumnName("modelo_neg")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.Nucleo)
                    .HasColumnName("nucleo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtraAplic)
                    .HasColumnName("otra_aplic")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patentado)
                    .HasColumnName("patentado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PptaValor)
                    .HasColumnName("ppta_valor")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrincipalesComp)
                    .HasColumnName("principales_comp")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PropiedadIntel)
                    .HasColumnName("propiedad_intel")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecomendTecn)
                    .HasColumnName("recomend_tecn")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Recomendaciones)
                    .HasColumnName("recomendaciones")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Replicable)
                    .HasColumnName("replicable")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Resolucion)
                    .HasColumnName("resolucion")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RutEmp)
                    .IsRequired()
                    .HasColumnName("rut_emp")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RutUsuario)
                    .IsRequired()
                    .HasColumnName("rut_usuario")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SolucSimil)
                    .HasColumnName("soluc_simil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TecnAlternativa)
                    .HasColumnName("tecn_alternativa")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TendenciaTecnologica)
                    .HasColumnName("tendencia_tecnologica")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCadVal)
                    .HasColumnName("tipo_cad_val")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEspec)
                    .HasColumnName("tipo_espec")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TipoFoco)
                    .HasColumnName("tipo_foco")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMadurez)
                    .HasColumnName("tipo_madurez")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoModeloNeg)
                    .HasColumnName("tipo_modelo_neg")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoOrigen)
                    .HasColumnName("tipo_origen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProceso)
                    .HasColumnName("tipo_proceso")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
