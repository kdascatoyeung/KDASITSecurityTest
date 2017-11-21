using System;
using System.Collections.Generic;

namespace ITSecurityTest.ViewModels
{
    public class DepartmentViewModel
    {
        public DepartmentViewModel()
        {
            Users = new List<UserViewModel>();
        }
        
        public int Id { get; set; }
        
        public string Code { get; set; }
        
        public string Name { get; set; }

        public string FullDisplayName
        {
            get
            {
                return Code + " - " + Name;
            }
        }
        
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserViewModel> Users { get; set; }
    }
}
