﻿using Project_Eticaret.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Eticaret.CORE.Mapping
{
    public class CoreMap<T> : EntityTypeConfiguration<T> where T : CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.ID).HasColumnName("ID")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Status).HasColumnName("Status").IsOptional();
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsOptional();
            Property(x => x.CreatedADUserName).HasColumnName("CreatedADUserName").IsOptional();
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsOptional();
            Property(x => x.CreatedComputerName).HasColumnName("CreatedComputerName").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsOptional();
            Property(x => x.ModifiedADUserName).HasColumnName("ModifiedADUserName").IsOptional();
            Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").IsOptional();
            Property(x => x.ModifiedComputerName).HasColumnName("ModifiedComputerName").IsOptional();
            Property(x => x.ModifiedIP).HasColumnName("ModifiedIP").IsOptional();
            
        }
    }
}
