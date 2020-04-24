﻿namespace MedApp.Data.ModelsConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Models;

    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> entity)
        {
            entity.HasMany(p => p.Doctors)
                  .WithOne(dp => dp.Patient)
                  .HasForeignKey(dp => dp.PatientId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(p => p.Appointments)
                  .WithOne(a => a.Patient)
                  .HasForeignKey(p => p.PatientId)
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(p => p.Prescriptions)
                  .WithOne(pr => pr.Patient)
                  .HasForeignKey(p => p.PatientId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}