using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMCollegeService.Models;
using ITMCollegeService.Context;

namespace ITMCollegeService.Repositories
{
    public interface INewsRepo
    {

    }
    public class NewsRepo : RepositoryBase<News>, INewsRepo
    {
        public NewsRepo(ITMCollegeContext iTMCollegeContext) : base(iTMCollegeContext)
        {

        }
    }
}
