using AutoMapper;

namespace ITSecurityTest.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ModelToViewModelMappingProfile>();
                x.AddProfile<ViewModelToModelMappingProfile>();
            });
        }
    }
}
