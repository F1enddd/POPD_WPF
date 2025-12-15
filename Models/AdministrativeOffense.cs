using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POPD_WPF.Models
{
    public partial class AdministrativeOffense
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("article")]
        public string Article { get; set; } = null!;
        [Column("name")]
        public string Name { get; set; } = null!;
        [Column("description")]
        public string? Description { get; set; }
        [Column("subject")]
        public string? Subject { get; set; }
        [Column("punishment")]
        public string? Punishment { get; set; }
        [Column("authority")]
        public string? Authority { get; set; }
        [Column("example")]
        public string? Example { get; set; }
    }
}
