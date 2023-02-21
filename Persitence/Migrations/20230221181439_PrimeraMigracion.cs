using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persitence.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CovidCase",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<int>(type: "int", nullable: true),
                    states = table.Column<int>(type: "int", nullable: true),
                    positive = table.Column<int>(type: "int", nullable: true),
                    negative = table.Column<int>(type: "int", nullable: true),
                    pending = table.Column<int>(type: "int", nullable: true),
                    hospitalizedCurrently = table.Column<int>(type: "int", nullable: true),
                    hospitalizedCumulative = table.Column<int>(type: "int", nullable: true),
                    inIcuCurrently = table.Column<int>(type: "int", nullable: true),
                    inIcuCumulative = table.Column<int>(type: "int", nullable: true),
                    onVentilatorCurrently = table.Column<int>(type: "int", nullable: true),
                    onVentilatorCumulative = table.Column<int>(type: "int", nullable: true),
                    dateChecked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    death = table.Column<int>(type: "int", nullable: true),
                    hospitalized = table.Column<int>(type: "int", nullable: true),
                    totalTestResults = table.Column<int>(type: "int", nullable: true),
                    lastModifiedTable = table.Column<DateTime>(type: "datetime2", nullable: true),
                    recovered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total = table.Column<int>(type: "int", nullable: true),
                    posNeg = table.Column<int>(type: "int", nullable: true),
                    deathIncrease = table.Column<int>(type: "int", nullable: true),
                    hospitalizedIncrease = table.Column<int>(type: "int", nullable: true),
                    negativeIncrease = table.Column<int>(type: "int", nullable: true),
                    positiveIncrease = table.Column<int>(type: "int", nullable: true),
                    totalTestResultsIncrease = table.Column<int>(type: "int", nullable: true),
                    hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidCase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CovidForState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<int>(type: "int", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    positive = table.Column<int>(type: "int", nullable: true),
                    probableCases = table.Column<int>(type: "int", nullable: true),
                    negative = table.Column<int>(type: "int", nullable: true),
                    pending = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    totalTestResultsSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    totalTestResults = table.Column<int>(type: "int", nullable: true),
                    hospitalizedCurrently = table.Column<int>(type: "int", nullable: true),
                    hospitalizedCumulative = table.Column<int>(type: "int", nullable: true),
                    inIcuCurrently = table.Column<int>(type: "int", nullable: true),
                    inIcuCumulative = table.Column<int>(type: "int", nullable: true),
                    onVentilatorCurrently = table.Column<int>(type: "int", nullable: true),
                    onVentilatorCumulative = table.Column<int>(type: "int", nullable: true),
                    recovered = table.Column<int>(type: "int", nullable: true),
                    lastUpdateEt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    checkTimeEt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    death = table.Column<int>(type: "int", nullable: true),
                    hospitalized = table.Column<int>(type: "int", nullable: true),
                    hospitalizedDischarged = table.Column<int>(type: "int", nullable: true),
                    dateChecked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    totalTestsViral = table.Column<int>(type: "int", nullable: true),
                    positiveTestsViral = table.Column<int>(type: "int", nullable: true),
                    negativeTestsViral = table.Column<int>(type: "int", nullable: true),
                    positiveCasesViral = table.Column<int>(type: "int", nullable: true),
                    deathConfirmed = table.Column<int>(type: "int", nullable: true),
                    deathProbable = table.Column<int>(type: "int", nullable: true),
                    totalTestEncountersViral = table.Column<int>(type: "int", nullable: true),
                    totalTestsPeopleViral = table.Column<int>(type: "int", nullable: true),
                    totalTestsAntibody = table.Column<int>(type: "int", nullable: true),
                    positiveTestsAntibody = table.Column<int>(type: "int", nullable: true),
                    negativeTestsAntibody = table.Column<int>(type: "int", nullable: true),
                    totalTestsPeopleAntibody = table.Column<int>(type: "int", nullable: true),
                    positiveTestsPeopleAntibody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    negativeTestsPeopleAntibody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    totalTestsPeopleAntigen = table.Column<int>(type: "int", nullable: true),
                    positiveTestsPeopleAntigen = table.Column<int>(type: "int", nullable: true),
                    totalTestsAntigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    positiveTestsAntigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fips = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    positiveIncrease = table.Column<int>(type: "int", nullable: true),
                    negativeIncrease = table.Column<int>(type: "int", nullable: true),
                    total = table.Column<int>(type: "int", nullable: true),
                    totalTestResultsIncrease = table.Column<int>(type: "int", nullable: true),
                    posNeg = table.Column<int>(type: "int", nullable: true),
                    dataQualityGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deathIncrease = table.Column<int>(type: "int", nullable: true),
                    hospitalizedIncrease = table.Column<int>(type: "int", nullable: true),
                    hash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    commercialScore = table.Column<int>(type: "int", nullable: false),
                    negativeRegularScore = table.Column<int>(type: "int", nullable: true),
                    negativeScore = table.Column<int>(type: "int", nullable: true),
                    positiveScore = table.Column<int>(type: "int", nullable: true),
                    score = table.Column<int>(type: "int", nullable: true),
                    grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CovidForState", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CovidCase");

            migrationBuilder.DropTable(
                name: "CovidForState");
        }
    }
}
