using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Tracking_Interface_API.Models;

namespace Tracking_Interface_API.Context
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }


        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VSTArticleDutyPaidRemain> VSTArticleDutyPaidRemains { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=10.3.0.122;Database=KPIPVirtualStock;User Id=sa;Password=sql2000;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.UseCollation("Thai_100_CI_AS");

            modelBuilder.Entity<VSTArticleDutyPaidRemain>(entity =>
            {
                entity.HasKey(e => e.id);

                entity.ToTable("VST_Article_Duty_Paid_Remain");

				entity.Property(e => e.article_code)
					.HasMaxLength(200)
					.IsUnicode(false);

				entity.Property(e => e.article_code_duty_paid)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                //entity.Property(e => e.timestamp);
                    
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
