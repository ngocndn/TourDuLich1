﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tour.DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TourENT : DbContext
    {
        public TourENT()
            : base("name=TourENT")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHIPHI> CHIPHIs { get; set; }
        public virtual DbSet<CHITIET> CHITIETs { get; set; }
        public virtual DbSet<DIADIEM> DIADIEMs { get; set; }
        public virtual DbSet<DOANDL> DOANDLs { get; set; }
        public virtual DbSet<GIATOUR> GIATOURs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIHINHDULICH> LOAIHINHDULICHes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<TOURDULICH> TOURDULICHes { get; set; }
    }
}
