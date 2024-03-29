﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndreFischbacherApp.DataContext.Entities
{
    public class InterestContent
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Contents")]
        public string Contents { get; set; }
        
        [Column("Title")]
        public string Title { get; set; }

        [Column("ImageUrl")]
        public string ImageUrl { get; set; }

        [Column("LastModified")]
        public DateTimeOffset LastModified { get; set; }

    }
}
