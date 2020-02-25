﻿using System;
using System.Collections.Generic;
using System.Text;
using CoopManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Models.Cooperados;
using CoopManagement.Models.Cursos;

namespace CoopManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Cooperado> Cooperados { get; set; }
    }
}
