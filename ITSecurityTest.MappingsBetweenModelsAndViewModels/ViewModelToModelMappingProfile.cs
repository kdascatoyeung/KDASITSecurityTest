using AutoMapper;
using ITSecurityTest.Models;
using ITSecurityTest.ViewModels;

namespace ITSecurityTest.Mappings
{
    public class ViewModelToModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToModelsMappings"; }
        }

        public ViewModelToModelMappingProfile()
        {
            CreateMap<DepartmentViewModel, Department>()
                .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id))
                .ForMember(m => m.Code, map => map.MapFrom(vm => vm.Code))
                .ForMember(m => m.Name, map => map.MapFrom(vm => vm.Name))
                .ForMember(m => m.IsDeleted, map => map.MapFrom(vm => vm.IsDeleted))
                .ForMember(m => m.Users, map => map.MapFrom(vm => vm.Users));

            CreateMap<GroupViewModel, Group>()
                .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id))
                .ForMember(m => m.Name, map => map.MapFrom(vm => vm.Name))
                .ForMember(m => m.IsDeleted, map => map.MapFrom(vm => vm.IsDeleted))
                .ForMember(m => m.Users, map => map.MapFrom(vm => vm.Users));

            CreateMap<UserViewModel, User>()
                .ForMember(m => m.Id, map => map.MapFrom(vm => vm.Id))
                .ForMember(m => m.Domain, map => map.MapFrom(vm => vm.Domain))
                .ForMember(m => m.LoginId, map => map.MapFrom(vm => vm.LoginId))
                .ForMember(m => m.DepartmentId, map => map.MapFrom(vm => vm.DepartmentId))
                .ForMember(m => m.GroupId, map => map.MapFrom(vm => vm.GroupId))
                .ForMember(m => m.IsAdmin, map => map.MapFrom(vm => vm.IsAdmin))
                .ForMember(m => m.IsDeleted, map => map.MapFrom(vm => vm.IsDeleted))
                .ForMember(m => m.Department, map => map.MapFrom(vm => vm.Department))
                .ForMember(m => m.Group, map => map.MapFrom(vm => vm.Group));
        }
    }
}
