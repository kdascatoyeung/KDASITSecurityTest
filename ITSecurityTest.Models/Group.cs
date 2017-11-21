using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ITSecurityTest.Models
{
    [Table("TB_Group")]
    public class Group
    {
        public Group()
        {
            Users = new List<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public bool IsDeleted { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
