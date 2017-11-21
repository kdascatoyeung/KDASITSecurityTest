using System;
using System.Collections.Generic;

namespace ITSecurityTest.ViewModels
{
    public class GroupViewModel
    {
        public GroupViewModel()
        {
            Users = new List<UserViewModel>();
        }
        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserViewModel> Users { get; set; }
    }
}
