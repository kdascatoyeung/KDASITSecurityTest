using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITSecurityTest.Models
{
    [Table("TB_Department")]
    public class Department
    {
        public Department()
        {
            Users = new List<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
