namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VeXeDbContext : DbContext
    {
        public VeXeDbContext()
            : base("name=VeXeDbContext")
        {
        }

        public virtual DbSet<CT_GOIHANG> CT_GOIHANG { get; set; }
        public virtual DbSet<CT_XE_LICHCHAY> CT_XE_LICHCHAY { get; set; }
        public virtual DbSet<CHUYEN> CHUYENs { get; set; }
        public virtual DbSet<DIADIEM> DIADIEMs { get; set; }
        public virtual DbSet<DVVANTAI> DVVANTAIs { get; set; }
        public virtual DbSet<LICHCHAY> LICHCHAYs { get; set; }
        public virtual DbSet<LOAIHANGHOA> LOAIHANGHOAs { get; set; }
        public virtual DbSet<LOAIXE> LOAIXEs { get; set; }
        public virtual DbSet<LOTRINH> LOTRINHs { get; set; }
        public virtual DbSet<PHIEUGOIHANG> PHIEUGOIHANGs { get; set; }
        public virtual DbSet<SODOGHE> SODOGHEs { get; set; }
        public virtual DbSet<TTKHACHHANG> TTKHACHHANGs { get; set; }
        public virtual DbSet<VE> VEs { get; set; }
        public virtual DbSet<XE> XEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_GOIHANG>()
                .Property(e => e.SOPGH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_GOIHANG>()
                .Property(e => e.MALOAIHH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_XE_LICHCHAY>()
                .Property(e => e.BIENSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_XE_LICHCHAY>()
                .Property(e => e.MACHUYEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_XE_LICHCHAY>()
                .HasMany(e => e.VEs)
                .WithRequired(e => e.CT_XE_LICHCHAY)
                .HasForeignKey(e => new { e.BIENSO, e.MALC })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUYEN>()
                .Property(e => e.MACHUYEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHUYEN>()
                .Property(e => e.SoKM)
                .HasPrecision(6, 0);

            modelBuilder.Entity<CHUYEN>()
                .HasMany(e => e.CT_XE_LICHCHAY)
                .WithRequired(e => e.CHUYEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUYEN>()
                .HasMany(e => e.LOTRINHs)
                .WithMany(e => e.CHUYENs)
                .Map(m => m.ToTable("CT_CHUYEN_LOTRINH").MapLeftKey("MACHUYEN").MapRightKey(new[] { "MADIEMDI", "MADIMDEN" }));

            modelBuilder.Entity<DIADIEM>()
                .Property(e => e.MADD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIADIEM>()
                .HasMany(e => e.LOTRINHs)
                .WithRequired(e => e.DIADIEM)
                .HasForeignKey(e => e.MADIEMDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DIADIEM>()
                .HasMany(e => e.LOTRINHs1)
                .WithRequired(e => e.DIADIEM1)
                .HasForeignKey(e => e.MADIMDEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DVVANTAI>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DVVANTAI>()
                .Property(e => e.TENDN)
                .IsUnicode(false);

            modelBuilder.Entity<DVVANTAI>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<DVVANTAI>()
                .HasMany(e => e.XEs)
                .WithRequired(e => e.DVVANTAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LICHCHAY>()
                .HasMany(e => e.CT_XE_LICHCHAY)
                .WithRequired(e => e.LICHCHAY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIHANGHOA>()
                .Property(e => e.MALOAIHH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIHANGHOA>()
                .HasMany(e => e.CT_GOIHANG)
                .WithRequired(e => e.LOAIHANGHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIXE>()
                .Property(e => e.MALX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIXE>()
                .HasMany(e => e.XEs)
                .WithRequired(e => e.LOAIXE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOTRINH>()
                .Property(e => e.MADIEMDI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOTRINH>()
                .Property(e => e.MADIMDEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOTRINH>()
                .Property(e => e.KhoangCach)
                .HasPrecision(6, 1);

            modelBuilder.Entity<PHIEUGOIHANG>()
                .Property(e => e.SOPGH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGOIHANG>()
                .Property(e => e.ID_VE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGOIHANG>()
                .HasMany(e => e.CT_GOIHANG)
                .WithRequired(e => e.PHIEUGOIHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SODOGHE>()
                .Property(e => e.BIENSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTKHACHHANG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TTKHACHHANG>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TTKHACHHANG>()
                .HasMany(e => e.VEs)
                .WithRequired(e => e.TTKHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VE>()
                .Property(e => e.ID_VE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VE>()
                .Property(e => e.QRCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VE>()
                .Property(e => e.BIENSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VE>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VE>()
                .HasMany(e => e.PHIEUGOIHANGs)
                .WithRequired(e => e.VE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XE>()
                .Property(e => e.BIENSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XE>()
                .Property(e => e.MALX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XE>()
                .Property(e => e.MADV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<XE>()
                .HasMany(e => e.CT_XE_LICHCHAY)
                .WithRequired(e => e.XE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XE>()
                .HasMany(e => e.SODOGHEs)
                .WithRequired(e => e.XE)
                .WillCascadeOnDelete(false);
        }
    }
}
