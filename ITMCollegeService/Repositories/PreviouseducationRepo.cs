using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface IPreviouseducationRepo
    {

    }
    public class PreviouseducationRepo : RepositoryBase<Previouseducation>, IPreviouseducationRepo
    {
        public PreviouseducationRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
