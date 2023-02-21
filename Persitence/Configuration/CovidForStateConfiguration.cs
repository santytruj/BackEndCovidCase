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
    public class CovidForStateConfiguration : IEntityTypeConfiguration<CovidForState>
    {
        public void Configure(EntityTypeBuilder<CovidForState> builder)
        {
            builder.ToTable("CovidForState");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.date);
            builder.Property(p => p.state);
            builder.Property(p => p.positive);
            builder.Property(p => p.probableCases);
            builder.Property(p => p.negative);
            builder.Property(p => p.pending);
            builder.Property(p => p.totalTestResultsSource);
            builder.Property(p => p.totalTestResults);
            builder.Property(p => p.hospitalizedCurrently);
            builder.Property(p => p.hospitalizedCumulative);
            builder.Property(p => p.inIcuCurrently);
            builder.Property(p => p.inIcuCumulative);
            builder.Property(p => p.onVentilatorCurrently);
            builder.Property(p => p.onVentilatorCumulative);
            builder.Property(p => p.recovered);
            builder.Property(p => p.lastUpdateEt);
            builder.Property(p => p.dateModified);
            builder.Property(p => p.checkTimeEt);
            builder.Property(p => p.death);
            builder.Property(p => p.hospitalized);
            builder.Property(p => p.hospitalizedDischarged);
            builder.Property(p => p.dateChecked);
            builder.Property(p => p.totalTestsViral);
            builder.Property(p => p.positiveTestsViral);
            builder.Property(p => p.negativeTestsViral);
            builder.Property(p => p.positiveCasesViral);
            builder.Property(p => p.deathConfirmed);
            builder.Property(p => p.deathProbable);
            builder.Property(p => p.totalTestEncountersViral);
            builder.Property(p => p.totalTestsPeopleViral);
            builder.Property(p => p.totalTestsAntibody);
            builder.Property(p => p.positiveTestsAntibody);
            builder.Property(p => p.negativeTestsAntibody);
            builder.Property(p => p.totalTestsPeopleAntibody);
            builder.Property(p => p.positiveTestsPeopleAntibody);
            builder.Property(p => p.negativeTestsPeopleAntibody);
            builder.Property(p => p.totalTestsPeopleAntigen);
            builder.Property(p => p.positiveTestsPeopleAntigen);
            builder.Property(p => p.totalTestsAntigen);
            builder.Property(p => p.positiveTestsAntigen);
            builder.Property(p => p.fips);
            builder.Property(p => p.positiveIncrease);
            builder.Property(p => p.negativeIncrease);
            builder.Property(p => p.total);
            builder.Property(p => p.totalTestResultsIncrease);
            builder.Property(p => p.posNeg);
            builder.Property(p => p.dataQualityGrade);
            builder.Property(p => p.deathIncrease);
            builder.Property(p => p.hospitalizedIncrease);
            builder.Property(p => p.hash);
            builder.Property(p => p.commercialScore);
            builder.Property(p => p.negativeRegularScore);
            builder.Property(p => p.negativeScore);
            builder.Property(p => p.positiveScore);
            builder.Property(p => p.score);
            builder.Property(p => p.grade);
            builder.Property(p => p.CreatedBy);
        }
    }
}
