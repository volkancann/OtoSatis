﻿using Microsoft.EntityFrameworkCore;
using OtoSatisServis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoSatisServis.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Servis> Servisler { get; set; }  
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-T8NAD5P;Database=OtoServisSatis;Trusted_Connection=True;TrustServerCertificate=True;integrated security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marka>().Property(m =>m.Adi ).IsRequired().HasColumnType("varchar(50)"); 
            modelBuilder.Entity<Rol>().Property(m =>m.Adi ).IsRequired().HasColumnType("varchar(50)");
            modelBuilder.Entity<Rol>().HasData(new Rol
            {

                Id = 1,
                Adi = "Admin"

            });

            modelBuilder.Entity<Kullanici>().HasData(new Kullanici
            {
                Id = 1,
                Adi = "Admin",
                      AktifMi = true,
                        EklenmeTarihi = DateTime.Now,
                       Email = "admin@otoservissatis.tc",
                       KullaniciAdi = "admin",
                       Sifre = "123456",
                    //  Rol = new Rol { Id = 1 },
                       RolId =1,
                       Soyadi="admin",
                       Telefon="0850"

            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
