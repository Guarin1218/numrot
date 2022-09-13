using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace backend.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("user_id", TypeName = "int")]        
        public int UserId { get; set; }
        
        [Column("document_number", TypeName = "varchar(20)")]        
        public string DocumentNumber { get; set; }

        [Column("first_name",TypeName = "varchar(40)")]
        public string FirstName { get; set; }

        [Column("middle_name", TypeName = "varchar(40)")]
        public string? MiddleName { get; set; }

        [Column("first_surname", TypeName = "varchar(40)")]
        public string FirstSurname { get; set; }

        [Column("second_surname", TypeName = "varchar(40)")]
        public string? SecondSurname { get; set; }

        [Column("phone_number", TypeName = "varchar(20)")]
        public string? PhoneNumber { get; set; }

        [Column("email", TypeName = "varchar(200)")]
        public string? Email { get; set; }

        [Column("address", TypeName = "text")]
        public string Address { get; set; }

        [Column("age", TypeName = "int")]        
        public int Age { get; set; }

        //[ForeignKey("role_id")]
        //public virtual Role Role { get; set; }        

        //public int GenderId { get; set; }

        //public Gender Gender { get; set; }
    }
}

