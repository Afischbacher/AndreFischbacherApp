using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AndreFischbacherApp.Repositories.Entities
{
    public class AboutContent
    {
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Content")]
        public string Content { get; set; }

        [Column("IsSubcard")]
        [DefaultValue(false)]
        public bool IsSubcard { get; set; }

        [Column("IconName")]
        public string IconName { get; set; }

        [Column("LastModified")]
        public DateTimeOffset LastModified { get; set; }    

    }
}
