﻿using CentroOdontologicoModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroOdontologicoData
{
    public class GcoContext : DbContext
    {
        public DbSet<TipoAtencion> TipoAtenciones { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Cita> Citas { get; set; }

        public GcoContext(): base("GcoRicardoPalma") 
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
