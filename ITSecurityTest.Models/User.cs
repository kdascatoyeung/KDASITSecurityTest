using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITSecurityTest.Models
{
    [Table("TB_User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Domain { get; set; }

        [StringLength(255)]
        public string LoginId { get; set; }

        public string FullLoginId
        {
            get
            {
                return Domain + "\\" + LoginId;
            }
        }
        public int DepartmentId { get; set; }

        public int GroupId { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Group Group { get; set; }

        public virtual Department Department { get; set; }
    }
}
