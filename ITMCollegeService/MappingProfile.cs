using AutoMapper;
using ITMCollegeService.DTO;
using ITMCollegeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Admin, GetAdminDTO>();
            CreateMap<ModifyAdminDTO, Admin>();
            //CreateMap<ModifyAdminDTO, Admin>()
            //    .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));
        }
    }
}
