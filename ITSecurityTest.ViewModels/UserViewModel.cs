using System;

namespace ITSecurityTest.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
        }
        
        public int Id { get; set; }
        
        public string Domain { get; set; }
        
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
        
        public string BatchNoPrefix { get; set; }
        
        public virtual DepartmentViewModel Department { get; set; }
        
        public virtual GroupViewModel Group { get; set; }
    }
}
