using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities
{
    public class Gender
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("gender_id", TypeName = "int")]
        public int GenderId { get; set; }

        [Column("name", TypeName = "varchar(200)")]
        public string name { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}

