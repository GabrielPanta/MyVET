﻿using Microsoft.EntityFrameworkCore;
using MyVet.Web.Data.Entities;
using MyVET.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVET.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Owner> Owners{ get; set; }
        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
    }
}
