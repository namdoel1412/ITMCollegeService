using ITMCollegeService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Contracts
{
    public interface IRepositoryWrapper
    {
        Task SaveAsync();
        public IAdminRepo AdminRepo { get; }
        public ICategoryNewsRepo CategoryNewsRepo { get; }
        public ICategoryRepo CategoryRepo { get; }
        public IContactRepo ContactRepo { get; }
        public ICourseRepo CourseRepo { get; }
        public IDepartmentRepo DepartmentRepo { get; }
        public IFacultyRepo FacultyRepo { get; }
        public IGenderRepo GenderRepo { get; }
        public INewsRepo NewsRepo { get; }
        public IPreviouseducationRepo PreviouseducationRepo { get; }
        public IRoleRepo RoleRepo { get; }
        public ISemesterRepo SemesterRepo { get; }
        public IStatusRepo StatusRepo { get; }
        public IStudentRepo StudentRepo { get; }
        public ISubjectRepo SubjectRepo { get; }
        public IUserRepo UserRepo { get; }
        public IUserRoleRepo UserRoleRepo { get; }
    }
}
