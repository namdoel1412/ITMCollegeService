using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface IStatusRepo
    {

    }
    public class StatusRepo : RepositoryBase<Status>, IStatusRepo
    {
        public StatusRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
