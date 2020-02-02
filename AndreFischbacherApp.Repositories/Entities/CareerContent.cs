using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

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

        [Column("IconCode")]
        public string IconCode { get; set; }

        public IEnumerable<CareerInformationContent> CareerInformationContents { get; set; }

    }
}
