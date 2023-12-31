﻿using BlogCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Aquí se deben agregar c/u de los modelos
        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Articulo> Articulo { get; set; }

        public DbSet<Slider> Slider { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}