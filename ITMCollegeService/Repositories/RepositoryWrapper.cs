using ITMCollegeService.Context;
using ITMCollegeService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMCollegeService.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ITMCollegeContext itmCollegeContext;
        public RepositoryWrapper(ITMCollegeContext _itmCollegeContext)
        {
            this.itmCollegeContext = _itmCollegeContext;
        }
        private IAdminRepo _AdminRepo;
        private ICategoryNewsRepo _CategoryNewsRepo;
        private ICategoryRepo _CategoryRepo;
        private ICollegeRepo _CollegeRepo;
        private ICollegeAddressRepo _CollegeAddressRepo;
        private IContactRepo _ContactRepo;
        private ICourseRepo _CourseRepo;
        private IDepartmentRepo _DepartmentRepo;
        private IFacultyRepo _FacultyRepo;
        private IGenderRepo _GenderRepo;
        private INewsRepo _NewsRepo;
        private IPreviouseducationRepo _PreviouseducationRepo;
        private IRoleRepo _RoleRepo;
        private ISemesterRepo _SemesterRepo;
        private IStatusRepo _StatusRepo;
        private IStudentRepo _StudentRepo;
        private ISubjectRepo _SubjectRepo;
        private IUserRepo _UserRepo;
        private IUserRoleRepo _UserRoleRepo;
        public IAdminRepo AdminRepo
        {
            get
            {
                if (_AdminRepo == null)
                {
                    _AdminRepo = new AdminRepo(itmCollegeContext);
                }
                return _AdminRepo;
            }
        }

        public ICategoryNewsRepo CategoryNewsRepo
        {
            get
            {
                if (_CategoryNewsRepo == null)
                {
                    _CategoryNewsRepo = new CategoryNewsRepo(itmCollegeContext);
                }
                return _CategoryNewsRepo;
            }
        }

        public ICategoryRepo CategoryRepo
        {
            get
            {
                if (_CategoryRepo == null)
                {
                    _CategoryRepo = new CategoryRepo(itmCollegeContext);
                }
                return _CategoryRepo;
            }
        }

        public ICollegeRepo CollegeRepo
        {
            get
            {
                if (_CollegeRepo == null)
                {
                    _CollegeRepo = new CollegeRepo(itmCollegeContext);
                }
                return _CollegeRepo;
            }
        }

        public ICollegeAddressRepo CollegeAddressRepo
        {
            get
            {
                if (_CollegeAddressRepo == null)
                {
                    _CollegeAddressRepo = new CollegeAddressRepo(itmCollegeContext);
                }
                return _CollegeAddressRepo;
            }
        }

        public IContactRepo ContactRepo
        {
            get
            {
                if (_ContactRepo == null)
                {
                    _ContactRepo = new ContactRepo(itmCollegeContext);
                }
                return _ContactRepo;
            }
        }

        public ICourseRepo CourseRepo
        {
            get
            {
                if (_CourseRepo == null)
                {
                    _CourseRepo = new CourseRepo(itmCollegeContext);
                }
                return _CourseRepo;
            }
        }

        public IDepartmentRepo DepartmentRepo
        {
            get
            {
                if (_DepartmentRepo == null)
                {
                    _DepartmentRepo = new DepartmentRepo(itmCollegeContext);
                }
                return _DepartmentRepo;
            }
        }

        public IFacultyRepo FacultyRepo
        {
            get
            {
                if (_FacultyRepo == null)
                {
                    _FacultyRepo = new FacultyRepo(itmCollegeContext);
                }
                return _FacultyRepo;
            }
        }

        public IGenderRepo GenderRepo
        {
            get
            {
                if (_GenderRepo == null)
                {
                    _GenderRepo = new GenderRepo(itmCollegeContext);
                }
                return _GenderRepo;
            }
        }

        public INewsRepo NewsRepo
        {
            get
            {
                if (_NewsRepo == null)
                {
                    _NewsRepo = new NewsRepo(itmCollegeContext);
                }
                return _NewsRepo;
            }
        }

        public IPreviouseducationRepo PreviouseducationRepo
        {
            get
            {
                if (_PreviouseducationRepo == null)
                {
                    _PreviouseducationRepo = new PreviouseducationRepo(itmCollegeContext);
                }
                return _PreviouseducationRepo;
            }
        }

        public IRoleRepo RoleRepo
        {
            get
            {
                if (_RoleRepo == null)
                {
                    _RoleRepo = new RoleRepo(itmCollegeContext);
                }
                return _RoleRepo;
            }
        }

        public ISemesterRepo SemesterRepo
        {
            get
            {
                if (_SemesterRepo == null)
                {
                    _SemesterRepo = new SemesterRepo(itmCollegeContext);
                }
                return _SemesterRepo;
            }
        }

        public IStatusRepo StatusRepo
        {
            get
            {
                if (_StatusRepo == null)
                {
                    _StatusRepo = new StatusRepo(itmCollegeContext);
                }
                return _StatusRepo;
            }
        }

        public IStudentRepo StudentRepo
        {
            get
            {
                if (_StudentRepo == null)
                {
                    _StudentRepo = new StudentRepo(itmCollegeContext);
                }
                return _StudentRepo;
            }
        }

        public ISubjectRepo SubjectRepo
        {
            get
            {
                if (_SubjectRepo == null)
                {
                    _SubjectRepo = new SubjectRepo(itmCollegeContext);
                }
                return _SubjectRepo;
            }
        }

        public IUserRepo UserRepo
        {
            get
            {
                if (_UserRepo == null)
                {
                    _UserRepo = new UserRepo(itmCollegeContext);
                }
                return _UserRepo;
            }
        }

        public IUserRoleRepo UserRoleRepo
        {
            get
            {
                if (_UserRoleRepo == null)
                {
                    _UserRoleRepo = new UserRoleRepo(itmCollegeContext);
                }
                return _UserRoleRepo;
            }
        }

        public async Task SaveAsync()
        {
            await itmCollegeContext.SaveChangesAsync();
        }
    }
}
