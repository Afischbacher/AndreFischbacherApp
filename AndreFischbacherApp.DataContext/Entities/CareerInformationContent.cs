using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
