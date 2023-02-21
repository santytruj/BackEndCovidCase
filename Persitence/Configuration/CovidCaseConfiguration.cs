using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persitence.Configuration
{
    public class CovidCaseConfiguration : IEntityTypeConfiguration<CovidCase>
    {
        public void Configure(EntityTypeBuilder<CovidCase> builder)
        {
            builder.ToTable("CovidCase");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.date).IsRequired(false);
            builder.Property(p => p.states).IsRequired(false);
            builder.Property(p => p.positive).IsRequired(false);
            builder.Property(p => p.negative).IsRequired(false);
            builder.Property(p => p.pending).IsRequired(false);
            builder.Property(p => p.hospitalizedCurrently).IsRequired(false);
            builder.Property(p => p.hospitalizedCumulative).IsRequired(false);
            builder.Property(p => p.inIcuCurrently).IsRequired(false);
            builder.Property(p => p.inIcuCumulative).IsRequired(false);
            builder.Property(p => p.onVentilatorCurrently).IsRequired(false);
            builder.Property(p => p.onVentilatorCumulative).IsRequired(false);
            builder.Property(p => p.dateChecked).IsRequired(false);
            builder.Property(p => p.death).IsRequired(false);
            builder.Property(p => p.hospitalized).IsRequired(false);
            builder.Property(p => p.totalTestResults).IsRequired(false);
            builder.Property(p => p.lastModifiedTable).IsRequired(false);
            builder.Property(p => p.recovered).IsRequired(false);
            builder.Property(p => p.total).IsRequired(false);
            builder.Property(p => p.posNeg).IsRequired(false);
            builder.Property(p => p.deathIncrease).IsRequired(false);
            builder.Property(p => p.hospitalizedIncrease).IsRequired(false);
            builder.Property(p => p.negativeIncrease).IsRequired(false);
            builder.Property(p => p.positiveIncrease).IsRequired(false);
            builder.Property(p => p.totalTestResultsIncrease).IsRequired(false);
            builder.Property(p => p.hash).IsRequired(false);
            builder.Property(p => p.CreatedBy);

        }
    }
}
