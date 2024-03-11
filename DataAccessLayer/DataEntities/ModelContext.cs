using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DataEntities;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }
    public ModelContext(DbContextOptions<ModelContext> options)
    : base(options)
    {
    }
    public virtual DbSet<PlantMaster> PlantMasters { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlantMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_C007563");

            entity.ToTable("PLANT_MASTER");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("NUMBER")
                .HasColumnName("ID");
            entity.Property(e => e.AuCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AU_CODE");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreatedOn)
                .HasColumnType("DATE")
                .HasColumnName("CREATED_ON");
            entity.Property(e => e.Dcp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DCP");
            entity.Property(e => e.Dsc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DSC");
            entity.Property(e => e.ExtraAttr1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR1");
            entity.Property(e => e.ExtraAttr10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR10");
            entity.Property(e => e.ExtraAttr2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR2");
            entity.Property(e => e.ExtraAttr3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR3");
            entity.Property(e => e.ExtraAttr4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR4");
            entity.Property(e => e.ExtraAttr5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR5");
            entity.Property(e => e.ExtraAttr6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR6");
            entity.Property(e => e.ExtraAttr7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR7");
            entity.Property(e => e.ExtraAttr8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR8");
            entity.Property(e => e.ExtraAttr9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA_ATTR9");
            entity.Property(e => e.GstnNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSTN_NO");
            entity.Property(e => e.LocationId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedOn)
                .HasColumnType("DATE")
                .HasColumnName("MODIFIED_ON");
            entity.Property(e => e.PanNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PAN_NO");
            entity.Property(e => e.PlantAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLANT_ADDRESS");
            entity.Property(e => e.PlantCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLANT_CODE");
            entity.Property(e => e.PlantDesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PLANT_DESC");
            entity.Property(e => e.PlantType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLANT_TYPE");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.SiteCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SITE_CODE");
            entity.Property(e => e.StateCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE_CODE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_TYPE");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
