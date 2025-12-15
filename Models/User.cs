using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace POPD_WPF.Models
{
    [Table("users")]
    public partial class User
    {
        [Key]
        [Column(TypeName = "TEXT(30)")]
        public string Login { get; set; } = null!;
        [Column(TypeName = "TEXT(30)")]
        public string Password { get; set; } = null!;
        [Column(TypeName = "TEXT(50)")]
        public string Name { get; set; } = null!;
    }
}
