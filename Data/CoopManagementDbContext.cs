using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoopManagement.Models;

    public class CoopManagementDbContext : DbContext
    {
        public CoopManagementDbContext (DbContextOptions<CoopManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<CoopManagement.Models.Curso> Curso { get; set; }
    }
