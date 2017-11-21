using AutoMapper;
using ITSecurityTest.Models;
using ITSecurityTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITSecurityTest.Mappings
{
    public class ModelToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ModelToViewModelMappings"; }
        }

        public ModelToViewModelMappingProfile()
        {
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<Group, GroupViewModel>();
            CreateMap<User, UserViewModel>();
        }
    }
}
