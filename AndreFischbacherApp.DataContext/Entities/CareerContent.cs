using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreFischbacherApp.DataContext.Entities
{
    public class CareerContent
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("CompanyName")]
        public string CompanyName { get; set; }

        [Column("PositionTitle")]
        public string PositionTitle { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("StartDate")]   
        public DateTime StartDate { get; set; }

        [Column("EndDate")]
        public DateTime? EndDate { get; set; }

        [Column("LastModified")]
        public DateTimeOffset LastModified { get; set; }

        [Column("CompanyLogoUrl")]
        public string CompanyLogoUrl { get; set; }

        public IEnumerable<CareerInformationContent> CareerInformationContents { get; set; }

    }
}
