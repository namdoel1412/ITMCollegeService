using AutoMapper;
using ITMCollegeService.DTO;
using ITMCollegeService.Models;
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
            CreateMap<UpdateAdminDTO, Admin>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Category, GetCategoryDTO>();
            CreateMap<ModifyCategoryDTO, Category>();
            CreateMap<UpdateCategoryDTO, Category>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<CategoryNews, GetCategoryNewsDTO>();
            CreateMap<ModifyCategoryNewsDTO, CategoryNews>();
            CreateMap<UpdateCategoryNewsDTO, CategoryNews>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<College, GetCollegeDTO>();
            CreateMap<ModifyCollegeDTO, College>();
            CreateMap<UpdateCollegeDTO, College>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Collegeaddress, GetCollegeAddressDTO>();
            CreateMap<ModifyCollegeAddressDTO, Collegeaddress>();
            CreateMap<UpdateCollegeAddressDTO, Collegeaddress>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Contact, GetContactDTO>();
            CreateMap<ModifyContactDTO, Contact>();
            CreateMap<UpdateContactDTO, Contact>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Course, GetCourseDTO>();
            CreateMap<ModifyCourseDTO, Course>();
            CreateMap<UpdateCourseDTO, Course>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

        }
    }
}
