using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Entities
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("role_id", TypeName = "int")]
        public int RoleId { get; set; }

        [Column("name",TypeName="varchar(200)")]
        public string Name { get; set; }

        //public virtual ICollection<User> Users { get; set; }

    }
}

