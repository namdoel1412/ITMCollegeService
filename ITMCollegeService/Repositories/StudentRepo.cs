using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface IStudentRepo
    {

    }
    public class StudentRepo : RepositoryBase<Student>, IStudentRepo
    {
        public StudentRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
