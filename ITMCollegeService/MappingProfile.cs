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

            CreateMap<Department, GetDepartmentDTO>();
            CreateMap<ModifyDepartmentDTO, Department>();
            CreateMap<UpdateDepartmentDTO, Department>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Faculty, GetFacultyDTO>();
            CreateMap<ModifyFacultyDTO, Faculty>();
            CreateMap<UpdateFacultyDTO, Faculty>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Gender, GetGenderDTO>();
            CreateMap<ModifyGenderDTO, Gender>();
            CreateMap<UpdateGenderDTO, Gender>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<News, GetNewsDTO>();
            CreateMap<ModifyNewsDTO, News>();
            CreateMap<UpdateNewsDTO, News>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Previouseducation, GetPreviousEducationDTO>();
            CreateMap<ModifyPreviousEducationDTO, Previouseducation>();
            CreateMap<UpdatePreviousEducationDTO, Previouseducation>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Role, GetRoleDTO>();
            CreateMap<ModifyRoleDTO, Role>();
            CreateMap<UpdateRoleDTO, Role>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Semester, GetSemesterDTO>();
            CreateMap<ModifySemesterDTO, Semester>();
            CreateMap<UpdateSemesterDTO, Semester>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Status, GetStatusDTO>();
            CreateMap<ModifyStatusDTO, Status>();
            CreateMap<UpdateStatusDTO, Status>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Student, GetStudentDTO>();
            CreateMap<ModifyStudentDTO, Student>();
            CreateMap<UpdateStudentDTO, Student>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<Subject, GetSubjectDTO>();
            CreateMap<ModifySubjectDTO, Subject>();
            CreateMap<UpdateSubjectDTO, Subject>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<User, GetUserDTO>();
            CreateMap<ModifyUserDTO, User>();
            CreateMap<UpdateUserDTO, User>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

            CreateMap<UserRole, GetUserRoleDTO>();
            CreateMap<ModifyUserRoleDTO, UserRole>();
            CreateMap<UpdateUserRoleDTO, UserRole>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcmember) => srcmember != null));

        }
    }
}
