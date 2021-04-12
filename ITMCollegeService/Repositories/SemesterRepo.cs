using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface ISemesterRepo
    {

    }
    public class SemesterRepo : RepositoryBase<Semester>, ISemesterRepo
    {
        public SemesterRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
