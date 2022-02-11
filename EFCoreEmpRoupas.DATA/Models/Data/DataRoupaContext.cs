using EFCoreEmpRoupas.DATA.Models;
using EFCoreEmpRoupas.WEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace EFCoreEmpRoupas.DATA.Data
{
    public class DataRoupaContext : DbContext
    {
        public DataRoupaContext()
        {
        }

        public DataRoupaContext(DbContextOptions<DataRoupaContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Roupa> Roupas { get; set; }
        public DbSet<RoupaEmprestimo> RoupaEmprestimos { get; set; }
        public DbSet<VW_RoupaEmprestimo> VW_RoupaEmprestimos { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            if (!optionsBuilder.IsConfigured)
            {
                /* Atenção: Instalar Pacotes na Biblioteca de Classe somente: 
                 * Microsoft.Extensions.Configiration.FileExtension                                                                               
                Microsoft.Extencsions.Configiration.Json                                                                                 
                Microsoft.Extensions.ConfigirationManager */

                //=========================================================================================

                /* OBS.: Mesmo sem  usar o Plugin EFCore Power Tool, assim como  não 
                estou usando, pois foi feito em EF Core normal com Migrations e update.
                A Configuração sendo feita aqui(ABAIXO) não precisa se feita no STARTUP.*/

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var stringConexao = configuration.GetConnectionString("ConectDB");

                optionsBuilder.UseSqlServer(stringConexao);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Roupa>()
                .Property(p => p.ValorLocacao)
                .HasColumnType("decimal(18,2)");
            
            modelBuilder.Entity<VW_RoupaEmprestimo>(entity =>
            {
                entity.ToView("VW_RoupaEmprestimo");
            });
        }
    }
}