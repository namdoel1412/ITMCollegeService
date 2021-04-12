using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface IGenderRepo
    {

    }
    public class GenderRepo : RepositoryBase<Gender>, IGenderRepo
    {
        public GenderRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
