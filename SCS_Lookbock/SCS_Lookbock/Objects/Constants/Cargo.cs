﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCS_Lookbock.Objects.Constants
{
    [Table("cargo")]
    public class Cargo
    {
        [Key]
        [Column("idcargo")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("nameloc")]
        public string NameLocal { get; set; }
    }
}
