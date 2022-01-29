using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreFischbacherApp.DataContext.Entities
{
    public class CareerInformationContent
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [ForeignKey("CareerContent")]
        public Guid CareerContentId { get; set; }

        [Column("CareerInformation")]
        public string CareerInformation { get; set; }
    }
}
